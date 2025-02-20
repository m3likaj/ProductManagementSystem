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
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        ProductManager productManager;
        CategoryManager categoryManager;
        
        public FrmProduct()
        {
            productManager = new ProductManager();
            categoryManager = new CategoryManager();

            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                Description = txtDescription.Text,
            };
            Category category = categoryManager.GetByName(cmbCategory.SelectedItem.ToString());
            product.Categories.Add(category);
            try
            {
                productManager.Add(product);
                MessageBox.Show("Product added");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                productManager.ResetContext();
     
            }
        }

        private void btnVeiwAll_Click(object sender, EventArgs e)
        {
            var products = productManager.GetProductsWithCategory();
            pnlDetails.Visible = false;
            pnlIdProcess.Visible = false;
            pnlCategories.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = products;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtID.Text = "";
            txtSearch.Text = "";
            cmbCategory.Text = "";
            txtCategoryName.Text = "";
            txtCategoryID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductId = int.Parse(txtID.Text),
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                Description = txtDescription.Text,
                BrandId = int.Parse(txtBrand.Text),
            };


            try
            {
                productManager.Update(product);
                MessageBox.Show("Customer updated");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                productManager.ResetContext();
               
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Product product = null;
            int.TryParse(txtSearch.Text, out int id);
            product = productManager.Get(id);
            
            if (product == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            MessageBox.Show("Customer will be deleted permanenetly!");
            productManager.Delete(product);
            MessageBox.Show("Customer Deleted");
        }

        private void ViewOrders_Click(object sender, EventArgs e)
        {
            Product product = null;
            int.TryParse(txtSearch.Text, out int id);
            product = productManager.Get(id);
            
            if (product == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }
            var values = productManager.GetOrderHistory(id);
            dataGridView1.DataSource = values;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = false;
            pnlDetails.Visible = false;
            pnlCategories.Visible = false;
            dataGridView1.Visible = false;
            updateCategoryCombo();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            Product product = null;
            int.TryParse(txtSearch.Text, out int id);
            product = productManager.Get(id);
            
            if (product == null && !pnlDetails.Visible && !btnDelete.Visible)
            {
                List<Product> products = productManager.GetProductsByName(txtSearch.Text);
            
                if (products.Count()==0)
                {
                    products = productManager.GetProductsByCategory(txtSearch.Text);
                }
                if (products.Count() == 0)
                {
                    MessageBox.Show("Customer not found");
                    return;
                }
                dataGridView1.DataSource = products;
                dataGridView1.Visible = true;
                return;
            }

            
            if (pnlDetails.Visible)
            {
                txtBrand.Text = product.BrandId.ToString();
                txtDescription.Text = product.Description;
                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
                txtStock.Text = product.Stock.ToString();

            }
            else
            {
                List<Product> productList = new List<Product>() { product };
                dataGridView1.DataSource = productList;
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
            pnlCategories.Visible = false;
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;

            
            btnFetch.Visible = true;
            btnDelete.Visible = false;
            pnlDetails.Visible = true;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            txtID.Visible = true;
            lblID.Visible = true;
            pnlCategories.Visible=false;
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            
            btnFetch.Visible = true;
            btnDelete.Visible = true;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            pnlCategories.Visible = false;
        }

        private void btnFetchMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
           
            btnFetch.Visible = true;
            btnDelete.Visible = false;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            pnlCategories.Visible = false;
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible;
        }

        private void btnCategoryMenu_Click(object sender, EventArgs e)
        {
            pnlCategories.Visible = true;
            pnlIdProcess.Visible = false;
            btnDelete.Visible = false;
            pnlDetails.Visible = false;
            dataGridView1.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            pnlCategories.Visible = true;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryName = txtCategoryName.Text,
            };
            try
            {
                categoryManager.Add(category);
                MessageBox.Show("Category added");
                btnClear_Click(sender, e);
                updateCategoryCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly"); 
                categoryManager.ResetContext();
                
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryID = int.Parse(txtID.Text),
                CategoryName = txtCategoryName.Text,
                
            };


            try
            {
                categoryManager.Update(category);
                MessageBox.Show("Category updated");
                btnClear_Click(sender, e);
                updateCategoryCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                categoryManager.ResetContext();

            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category category = null;
            int.TryParse(txtCategoryID.Text, out int id);
            category = categoryManager.Get(id);

            if (category == null)
            {
                MessageBox.Show("Category not found");
                return;
            }
            MessageBox.Show("Category will be deleted permanenetly!");
            categoryManager.Delete(category);
            MessageBox.Show("Category Deleted");
            updateCategoryCombo();
        }

        private void btnListCategory_Click(object sender, EventArgs e)
        {
            btnVeiwAll_Click(sender, e);
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateCategoryCombo()
        {
            var values = categoryManager.GetAll();
            cmbCategory.DataSource = values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
    }
}


 
