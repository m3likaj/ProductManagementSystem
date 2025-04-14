using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new FrmCustomer();
            customerForm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var productForm = new FrmProduct();
            productForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            var categoryForm = new FrmCategory();
            categoryForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new FrmOrder();
            orderForm.Show();
        }
    }
}
