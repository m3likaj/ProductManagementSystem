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

        }

        private void btnHistoryMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnVeiwAll_Click(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Add",   // Column header
                Text = "Add",       // Default button text
                UseColumnTextForButtonValue = true, // Ensures the button displays text
                Name = "btnAction"       // Name for identification
            };

            // Add the button column to DataGridView
            dataGridView1.Columns.Add(buttonColumn);

            // Subscribe to the CellClick event to handle button clicks
           // dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.DataSource= productManager.GetProductsWithCategory();
        }
    }
}
