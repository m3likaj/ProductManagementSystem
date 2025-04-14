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
    public partial class FrmCategory : Form
    {
        CategoryManager categoryManager;
        Context context;
        public FrmCategory()
        {
            context = new Context();
            categoryManager = new CategoryManager(context);
            
            InitializeComponent();
        }

        private void btnVeiwAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = categoryManager.GetAll();
            pnlCategories.Visible = false;
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = false;
            dataGridView1.Visible = false;
            pnlCategories.Visible = true;
            btnAddCategory.Visible = true;
            btnUpdateCategory.Visible = false;
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = false;
            dataGridView1.Visible = false;
            pnlCategories.Visible = true;
            btnAddCategory.Visible = false;
            btnUpdateCategory.Visible = true;
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            dataGridView1.Visible = false;
            pnlCategories.Visible = false;
            btnDelete.Visible = true;
        }

        private void btnFetchMenu_Click(object sender, EventArgs e)
        {
            pnlIdProcess.Visible = true;
            dataGridView1.Visible = false;
            pnlCategories.Visible = false;
            btnDelete.Visible = false;
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
                CategoryID = int.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text,

            };


            try
            {
                categoryManager.Update(category);
                MessageBox.Show("Category updated");
                btnClear_Click(sender, e);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all areas correctly");
                
                categoryManager.ResetContext();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            Category category = null;
            int.TryParse(txtSearch.Text, out int id);
            category = categoryManager.Get(id);
            if (category == null)
            {
                category = categoryManager.GetByName(txtSearch.Text);
            }
            if (category == null)
            {
                MessageBox.Show("Category not found");
                return;
            }
               
           dataGridView1.DataSource = category;
           dataGridView1.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Category category = null;
            int.TryParse(txtCategoryID.Text, out int id);
            category = categoryManager.Get(id);
            if (category == null)
            {
                MessageBox.Show("Category not found");
                return;
            }
            DialogResult result = MessageBox.Show("Category will be deleted permanenetly!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                categoryManager.Delete(category);
                MessageBox.Show("Category Deleted");
            }
            else
            {
                return;
            }
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible;
            var menuForm = new FrmMenu();
            menuForm.Show();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            pnlCategories.Visible = false;
            pnlIdProcess.Visible = false;
            dataGridView1.Visible = false;
        }
    }
}
