using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProductManagementSystem.BusinessLayer;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmCustomer : Form
    {
        private readonly CustomerManager customerManager;
        public FrmCustomer()
        {
            customerManager = new CustomerManager();
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txtFirstName.Text,
                Surname = txtSurName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text
            };
            try
            {
                customerManager.Add(customer);
                MessageBox.Show("Customer added");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                customerManager.ResetContext();
            }

        }

        private void btnVeiwAll_Click(object sender, EventArgs e)
        {
            var customers = customerManager.GetAll();
            pnlDetails.Visible = false;
            pnlIdProcess.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = customers;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSurName.Text = "";
            txtFirstName.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtID.Text, out int id);
            var customer = customerManager.Get(id);
            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            customer.Name = txtFirstName.Text;
            customer.Surname = txtSurName.Text;
            customer.Email = txtEmail.Text;
            customer.PhoneNumber = txtPhone.Text;
            customer.Address = txtAddress.Text;
            try
            {
                customerManager.Update(customer);
                MessageBox.Show("Customer updated");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                customerManager.ResetContext();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Customer customer = null;
            int.TryParse(txtSearch.Text, out int id);
            customer = customerManager.Get(id);
            if (customer == null)
            {
                customer = customerManager.GetCustomerByPhone(txtSearch.Text);
            }
            if (customer == null)
            {
                customer = customerManager.GetCustomerByEmail(txtSearch.Text);
            }
            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            MessageBox.Show("Customer will be deleted permanenetly!");
            customerManager.Delete(customer);
            MessageBox.Show("Customer Deleted");
        }

        private void ViewOrders_Click(object sender, EventArgs e)
        {
            Customer customer = null;
            int.TryParse(txtSearch.Text, out int id);
            customer = customerManager.Get(id);
            if (customer == null)
            {
                customer = customerManager.GetCustomerByPhone(txtSearch.Text);
            }
            if (customer == null)
            {
                customer = customerManager.GetCustomerByEmail(txtSearch.Text);
            }
            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            var values = customerManager.GetOrderHistory(customer.CustomerID);
            dataGridView1.DataSource = values;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = false;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            Customer customer = null;
            int.TryParse(txtSearch.Text, out int id);
            customer = customerManager.Get(id);
            if (customer == null)
            {
                customer = customerManager.GetCustomerByPhone(txtSearch.Text);
            }
            if (customer == null)
            {
                customer = customerManager.GetCustomerByEmail(txtSearch.Text);
            }
            if (customer == null && !pnlDetails.Visible && !btnOrdersHistory.Visible && !btnDelete.Visible)
            {
                List<Customer> customers = customerManager.GetCustomerByName(txtSearch.Text);
                dataGridView1.DataSource = customers;
                dataGridView1.Visible = true;
                return;
            }

            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            if (pnlDetails.Visible)
            {
                txtID.Text = customer.CustomerID.ToString();
                txtFirstName.Text = customer.Name;
                txtSurName.Text = customer.Surname;
                txtEmail.Text = customer.Email;
                txtPhone.Text = customer.PhoneNumber;
                txtAddress.Text = customer.Address;
            }
            else
            {
                List<Customer> customerList = new List<Customer>() { customer };
                dataGridView1.DataSource = customerList;
                dataGridView1.Visible = true;
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = false;
            pnlDetails.Visible = true;
            dataGridView1.Visible = false;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            txtID.Visible = false;
            lblID.Visible = false;
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;

            btnOrdersHistory.Visible = false;
            btnFetch.Visible = true;
            btnDelete.Visible = false;
            pnlDetails.Visible = true;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            txtID.Visible = true;
            lblID.Visible = true;
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            btnOrdersHistory.Visible = false;
            btnFetch.Visible = true;
            btnDelete.Visible = true;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
        }

        private void btnFetchMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            btnOrdersHistory.Visible = false;
            btnFetch.Visible = true;
            btnDelete.Visible = false;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible;
        }

        private void btnHistoryMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            btnOrdersHistory.Visible = true;
            btnFetch.Visible = true;
            btnDelete.Visible = false;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
        }
    }
}

