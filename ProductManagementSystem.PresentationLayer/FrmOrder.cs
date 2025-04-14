using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        CustomerManager customerManager;
        private Dictionary<int, int> productQuantities = new Dictionary<int, int>();
        bool MakeOrder = true;
        Order order;

        public FrmOrder()
        {
            context = new Context();
            productManager = new ProductManager(context);
            orderManager = new OrderManager(context);
            customerManager = new CustomerManager(context);
            InitializeComponent();

        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productManager.getProductsWithPrice();
            dataGridView1.Visible = true;
            pnlAddCustomer.Visible = false;
            btnMakeOrder_Click(sender, e);
        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            if (MakeOrder)
            {
                Product product = null;
                int.TryParse(txtSearch.Text, out int id);
                product = productManager.Get(id);

                if (product == null)
                {
                    var products = productManager.GetProductsByName(txtSearch.Text, false);

                    if (products.Count() == 0)
                    {
                        products = productManager.GetProductsByCategory(txtSearch.Text, false);
                    }
                    if (products.Count() == 0)
                    {
                        MessageBox.Show("Product not found");
                        return;
                    }
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = products;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                    btnDone.Visible = true;
                    return;
                }

                else
                {
                    var p = new
                    {
                        ProductID = product.ProductId,
                        Name = product.Name,
                        Price = product.Price
                    };
                    List<object> productList = new List<object>() { p };
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = productList;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                }
            }
            else
            {
                Order o = null;
                int.TryParse(txtSearch.Text, out int id);
                o = orderManager.Get(id);
                if (o == null)
                {
                    var values = orderManager.GetOrderByCustomer(txtSearch.Text);

                    if (values.Count() == 0)
                    {
                        values = orderManager.GetOrderByStatus(txtSearch.Text);
                    }
                    if (values.Count() == 0)
                    {
                        MessageBox.Show("Order not found");
                        return;
                    }
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = values;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                    btnDone.Visible = true;
                    return;
                }
                else {
                    var retrievedOrder = new
                    {
                        OrderID = o.OrderId,
                        Customer = o.Customer.Name + " " + o.Customer.Surname,
                        Products = (o.OrderProducts.Count() > 0) ? orderManager.getProducts(o.OrderProducts) : "no products",// Works in memory
                        Price = o.TotalPrice,
                        Status = o.OrderStatus
                    };
                    var orderList = new List<object> { retrievedOrder };
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = orderList;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                }
            }

        }


        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrder = true;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid(); // Add quantity and buttons again
            btnConfirm.Visible = false;
            btnDone.Visible = true;
            btnBack.Visible = false;
            btnManage.Visible = false;
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
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                if (productQuantities.TryGetValue(productId, out int savedQty))
                {
                    row.Cells["Quantity"].Value = savedQty;
                }
                else
                {
                    row.Cells["Quantity"].Value = 0;
                }

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
                int productId;
                // Check if the clicked cell is the button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAddProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                    productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    Product product = productManager.Get(productId);
                    if (product.Stock <= quantity)
                    {
                        MessageBox.Show("there is no more" + product.Name + "in stock");
                    }
                    else
                    {

                        quantity++;
                        productQuantities[productId] = quantity;
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                    } 
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnRemoveProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity > 0)
                    {
                        quantity--;
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                        productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                        productQuantities[productId] = quantity;
                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be less than 0");
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnOrderDetails")
                {
            
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
                    dataGridView1.DataSource = orderManager.GetOrderDetails(id);
                    btnBack.Visible = true;
                    btnManage.Visible = true;
                }
                    dataGridView1.Refresh();
            }
        }


        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            order = new Order
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
                dataGridView1.Visible = false;
                pnlAddCustomer.Visible = true;
                pnlCDetails.Visible = false;
                pnlFindCustomer.Visible = false;
                btnGoToCustomerPage.Visible = false;
                
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
            if (MakeOrder)
            {
                btnMakeOrder_Click(sender, e);
            }
            else
            {
                btnManageOrders_Click(sender, e);
            }
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            MakeOrder = false;
            btnDone.Visible = false;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            btnManage.Visible = false;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = orderManager.GetOrders();

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            DataGridViewButtonColumn buttonColumnManage = new DataGridViewButtonColumn
            {
                HeaderText = "Details",
                Name = "btnOrderDetails",
                UseColumnTextForButtonValue = false  // Allows setting text per cell
            };
            
            dataGridView1.Columns.Add(buttonColumnManage); // Add button column
            // Initialize rows with default values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["btnOrderDetails"].Value = "Details";
            }
            // Subscribe to events
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            int.TryParse(txtFindCustomer.Text, out int id);
            Customer customer = null;
            customer = customerManager.Get(id);
            if (customer == null)
            {
                customer = customerManager.GetCustomerByPhone(txtSearch.Text);
            }
            if (customer == null)
            {
                customer = customerManager.GetCustomerByEmail(txtSearch.Text);
            }
            if(customer == null)
            {
                MessageBox.Show("Customer not Found");
            }
            else
            {
                pnlCDetails.Visible = true;
                lblCid.Text = customer.CustomerID.ToString();
                lblCemail.Text = customer.Email;
                lblCname.Text = customer.Name;
                lblCphone.Text = customer.PhoneNumber;
            }
        }

        private void btnGoToCustomerPage_Click(object sender, EventArgs e)
        {
            var customerForm = new FrmCustomer();
            customerForm.Show();
        }

        private void btnAddAndOrder_Click(object sender, EventArgs e)
        {
            int.TryParse(lblCid.Text, out int id);
            Customer customer = customerManager.Get(id);
            order.CustomerID = id;
            
            foreach (var item in order.OrderProducts)
            {
                Product product = productManager.Get(item.ProductID);
                product.Stock -= item.Quantity;
                productManager.Update(product);
            }
            context.Orders.Add(order);
            context.SaveChanges();
            MessageBox.Show("Order confirmed!");

            // Reset grid
            pnlAddCustomer.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            productQuantities.Clear();
            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid(); // Add quantity and buttons again
            btnMakeOrder_Click(sender, e);
         
        }

        private void rbExisting_CheckedChanged(object sender, EventArgs e)
        {
            pnlFindCustomer.Visible = true;
            pnlCDetails.Visible = false;
            btnGoToCustomerPage.Visible = false;
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            btnGoToCustomerPage.Visible = true;
            pnlFindCustomer.Visible = false;
            pnlCDetails.Visible = false;
        }
    }
}


