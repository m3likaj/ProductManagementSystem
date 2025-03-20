using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ProductManagementSystem.BusinessLayer;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmOrder : Form
    {
        ProductManager productManager;
        Context context;
        
        public FrmOrder()
        {
            context = new Context();
            productManager = new ProductManager(context);
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

        private void btnHistoryMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnVeiwAll_Click(object sender, EventArgs e)
        {


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
                // Get the quantity value
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
            
                // Check if the clicked cell is the button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAddProduct")
                {
                    quantity++;
                    dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnRemoveProduct")
                {
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

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}


