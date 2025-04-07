using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;
using ProductManagementSystem.BusinessLayer;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmOrder : Form
    {
        ProductManager productManager;
        OrderManager orderManager;
        Context context;

        public FrmOrder()
        {
            context = new Context();
            productManager = new ProductManager(context);
            orderManager = new OrderManager(context);
            InitializeComponent();

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            Product product = null;
            int.TryParse(txtSearch.Text, out int id);
            product = productManager.Get(id);

            if (product == null)
            {
                var products = productManager.GetProductsByName(txtSearch.Text);

                if (products.Count() == 0)
                {
                    products = productManager.GetProductsByCategory(txtSearch.Text);
                }
                if (products.Count() == 0)
                {
                    MessageBox.Show("Product not found");
                    return;
                }
                dataGridView1.DataSource = products;
                dataGridView1.Visible = true;
                return;
            }

            else
            {
                List<Product> productList = new List<Product>() { product };
                dataGridView1.DataSource = productList;
                dataGridView1.Visible = true;
            }

        }


        private void btnVeiwAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid(); // Add quantity and buttons again
            btnConfirm.Visible = false;
            btnDone.Visible = true;
        }

        private void add_columns_to_grid()
        {
            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            DataGridViewButtonColumn buttonColumnAdd = new DataGridViewButtonColumn
            {
                HeaderText = "Add",
                Name = "btnAddProduct",
                UseColumnTextForButtonValue = false  // Allows setting text per cell
            };
            DataGridViewButtonColumn buttonColumnRemove = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Name = "btnRemoveProduct",
                UseColumnTextForButtonValue = false  // Allows setting text per cell
            };

            dataGridView1.Columns.Add("Quantity", "Quantity"); // Add Quantity column
            dataGridView1.Columns.Add(buttonColumnAdd); // Add button column
            dataGridView1.Columns.Add(buttonColumnRemove); // Add button column

            // Initialize rows with default values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Quantity"].Value = 0;
                row.Cells["btnAddProduct"].Value = "Add"; // Set initial button text
                row.Cells["btnRemoveProduct"].Value = "Remove";
            }

            // Subscribe to events
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked within valid bounds
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int quantity;
                // Check if the clicked cell is the button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAddProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    quantity++;
                    dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnRemoveProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity > 0)
                    {
                        quantity--;
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be less than 0");
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnManageOrder")
                {
            
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
                    dataGridView1.DataSource = orderManager.GetOrderDetails(id);
                }
                    dataGridView1.Refresh();
            }
        }


        private void FrmOrder_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                OrderProducts = new List<OrderProduct>(),
                TotalPrice = 0,
                OrderStatus = "Pending"
            };

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty);

                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                Product product = productManager.Get(productId);


                order.OrderProducts.Add(new OrderProduct
                {
                    OrderID = order.OrderId,
                    ProductID = product.ProductId,
                    Quantity = qty,
                    
                });
                order.TotalPrice += product.Price * qty;

            }
            if (order.OrderProducts.Count > 0)
            {
                context.Orders.Add(order);
                context.SaveChanges();

                MessageBox.Show("Order confirmed!");

                // Reset grid
                dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
                dataGridView1.DataSource = productManager.getProductsWithPrice();
                add_columns_to_grid(); // Add quantity and buttons again
                btnConfirm.Visible = false;
                btnDone.Visible = true;
            }
            else
            {
                MessageBox.Show("No products selected.");
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            var filtered = new List<(Product product, int quantity)>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Quantity"].Value != null &&
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty) &&
                    qty > 0)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    Product product = productManager.Get(productId);

                    if (product != null)
                        filtered.Add((product, qty));
                }
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show("No products Selected");
                return;
            }

            // Rebind filtered product list
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = filtered.Select(x => new
            {
                ProductID = x.product.ProductId,
                Name = x.product.Name,
                Price = x.product.Price
            }).ToList();

            add_columns_to_grid();

            // Restore quantity values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                int qty = filtered.First(x => x.product.ProductId == productId).quantity;

                row.Cells["Quantity"].Value = qty;
                row.Cells["btnAddProduct"].Value = "Add";
                row.Cells["btnRemoveProduct"].Value = "Remove";
            }

            btnConfirm.Visible = true;
            btnDone.Visible = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            btnDone.Visible = false;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = orderManager.GetOrders();

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            DataGridViewButtonColumn buttonColumnManage = new DataGridViewButtonColumn
            {
                HeaderText = "Manage",
                Name = "btnManageOrder",
                UseColumnTextForButtonValue = false  // Allows setting text per cell
            };
            
            dataGridView1.Columns.Add(buttonColumnManage); // Add button column
            // Initialize rows with default values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["btnManageOrder"].Value = "Manage";
            }
            // Subscribe to events
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }
    }
}


