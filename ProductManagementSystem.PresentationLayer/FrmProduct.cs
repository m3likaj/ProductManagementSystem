using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class FrmProduct : Form
    {
        Context context;
        ProductManager productManager;
        CategoryManager categoryManager;
        List<int> SelectedCategories;
        
        public FrmProduct()
        {
            context = new Context();
            productManager = new ProductManager(context);
            categoryManager = new CategoryManager(context);
            SelectedCategories = new List<int>();

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

            productManager.AddCategoryToProduct(SelectedCategories, product);


            try
            {

                productManager.Add(product);
                MessageBox.Show("Product added");
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //productManager.ResetContext();
     
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
            txtSearch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var categories = productManager.GetContext().Categories
                     .Where(c => SelectedCategories.Contains(c.CategoryID))
                     .ToList();

            Product product = new Product()
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                Description = txtDescription.Text,
                Categories = categories,
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
               // productManager.ResetContext();
               
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Product product = null;
            int.TryParse(txtSearch.Text, out int id);
            product = productManager.Get(id);
            
            if (product == null)
            {
                MessageBox.Show("product not found");
                return;
            }
            DialogResult result = MessageBox.Show("Product will be deleted permanenetly!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                productManager.Delete(product);
                MessageBox.Show("Product Deleted");
            }
            else
            {
                return;
            }
           
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
                var products = productManager.GetProductsByName(txtSearch.Text);
            
                if (products.Count()==0)
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
            SelectedCategories.Clear();
            flowLayoutPanel1.Controls.Clear();
            updateCategoryCombo();
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
            SelectedCategories.Clear();
            flowLayoutPanel1.Controls.Clear();
            updateCategoryCombo();
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
            SelectedCategories.Clear();
            
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
               // categoryManager.ResetContext();
                
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
               // categoryManager.ResetContext();

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
            // Get the selected item's text
            string selectedText = cmbCategory.Text;
            Category category = cmbCategory.SelectedItem as Category;

            // Check if a label with the same text already exists (avoid duplicates)
            foreach (Label lbl in flowLayoutPanel1.Controls.OfType<Label>())
            {
                if (lbl.Text == selectedText) return; // Do nothing if the label already exists
            }

            
            if (category.CategoryID > 0)
            {
                // Create a new label
                Label newLabel = new Label
                {
                    Text = selectedText,
                    AutoSize = true,
                    Padding = new Padding(5), // Add some spacing
                    BackColor = Color.LightGray, // Give it a distinct look
                    Margin = new Padding(3), // Space between labels
                    Cursor = Cursors.Hand // Change cursor to indicate clickability
                };

                if (category.CategoryID > 0)
                {
                    SelectedCategories.Add(category.CategoryID);
                }



                // Attach click event to remove the label and perform extra actions
                newLabel.Click += (s, ev) =>
                {
                    // Confirm before removing

                    flowLayoutPanel1.Controls.Remove(newLabel); // Remove from FlowLayoutPanel
                    SelectedCategories.Remove(category.CategoryID);

                };

                // Add label to FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newLabel);
            }
        }

        private void updateCategoryCombo()
        {
         
            var values = categoryManager.GetAll();
            var categoryList = new List<Category>
                                {
                                    new Category { CategoryID = 0, CategoryName = "-- Select a category --" } 
                                };

            categoryList.AddRange(values);

            cmbCategory.DataSource = categoryList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = 0; 

        }
    }
}


 
