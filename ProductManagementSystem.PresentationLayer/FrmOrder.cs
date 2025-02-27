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
                HeaderText = "Add",   // Column header
                Text = "Add",       // Default button text
                UseColumnTextForButtonValue = true, // Ensures the button displays text
                Name = "btnAddProduct"       // Name for identification
            };

            dataGridView1.Columns.Add("Quantity", "Quantity"); // Add a new column
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Quantity"].Value = 0;
            }


            // Add the button column to DataGridView
            dataGridView1.Columns.Add(buttonColumn);

            // Subscribe to the CellClick event to handle button clicks

            dataGridView1.CellClick += dataGridView1_CellContentClick;
           
            dataGridView1.CellEnter += dataGridView1_CellEnter;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private NumericUpDown numericUpDown = new NumericUpDown(); // Reusable control

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


