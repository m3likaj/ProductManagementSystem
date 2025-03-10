using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManagementSystem.BusinessLayer;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmOrder : Form
    {
        ProductManager productManager;
        Context context;
        private NumericUpDown numericUpDown = new NumericUpDown(); // Reusable control 
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

            if (product == null && !btnDelete.Visible)
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
                MessageBox.Show("Product found");
                var values = products.Select(x => new
                {
                    ProductID = ((Product)x).ProductId,
                    Name = ((Product)x).Name,
                    Price = ((Product)x).Price,
                    Stock = ((Product)x).Stock,

                }).ToList();

               // dataGridView1.Columns.Clear();

                //dataGridView1.DataSource = values.Cast<object>().ToList();

                dataGridView1.DataSource = products;
                
                return;
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
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Name = "btnAddProduct",
                UseColumnTextForButtonValue = false  // Allows setting text per cell
            };

            dataGridView1.Columns.Add("Quantity", "Quantity"); // Add Quantity column
            dataGridView1.Columns.Add(buttonColumn); // Add button column

            // Initialize rows with default values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Quantity"].Value = 0;
                row.Cells["btnAddProduct"].Value = "Add"; // Set initial button text
            }

            // Subscribe to events
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked within valid bounds
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked cell is the button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAddProduct")
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Get the quantity value
                    int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity > 0)
                    {
                        // Toggle between "Add" and "Added"
                        buttonCell.Value ="Added";
                    }
                    else
                    {
                        MessageBox.Show("Please set a quantity before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // 🔥 Refresh to apply changes
                    dataGridView1.Refresh();
                }
            }
        }

        

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Get the button cell in the same row
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView1.Rows[e.RowIndex].Cells["btnAddProduct"];

                // Get the quantity value
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                // Change the button text based on the quantity
                buttonCell.Value = (buttonCell.Value.ToString() == "Add") ? "Added" : "Add";

                // 🔥 Refresh to update the UI
                dataGridView1.Refresh();
            }
        }






        private void FrmOrder_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productManager.getProductsWithPrice();
            dataGridView1.Controls.Add(numericUpDown);
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.CellLeave += dataGridView1_CellLeave;

            // Configure NumericUpDown
            numericUpDown.Visible = false; // Initially hidden
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 100;
            numericUpDown.Leave += NumericUpDown_Leave;
            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;

            // Add NumericUpDown to DataGridView
          
            add_columns_to_grid();
        }




        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SaveNumericUpDownValue(); // Ensure last value is saved before switching cells

            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                numericUpDown.Tag = e.RowIndex; // Set Tag before assigning value

                if (row.Cells[e.ColumnIndex].Value != null && int.TryParse(row.Cells[e.ColumnIndex].Value.ToString(), out int value))
                {
                    numericUpDown.Value = value;
                }
                else
                {
                    numericUpDown.Value = 0;
                }

                Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                numericUpDown.Bounds = new Rectangle(cellRect.Location, cellRect.Size);
                numericUpDown.Visible = true;
                numericUpDown.Focus();
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Tag is int rowIndex && rowIndex >= 0)
            {
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = numericUpDown.Value;
            }
        }

        private void NumericUpDown_Leave(object sender, EventArgs e)
        {
            SaveNumericUpDownValue();
            numericUpDown.Visible = false; // Hide after saving
            dataGridView1.Focus(); // Ensure focus returns to DataGridView
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                SaveNumericUpDownValue();
            }
        }

        private void SaveNumericUpDownValue()
        {
            if (numericUpDown.Tag is int rowIndex && rowIndex >= 0)
            {
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = numericUpDown.Value;
            }
        }

    }
}


