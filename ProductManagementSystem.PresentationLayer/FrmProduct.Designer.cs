﻿namespace ProductManagementSystem.PresentationLayer
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlIdProcess = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnVeiwAll = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCategoriesMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnUpdateMenu = new System.Windows.Forms.Button();
            this.btnFetchMenu = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnListCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlIdProcess.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.btnShowMenu);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Location = new System.Drawing.Point(8, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(738, 54);
            this.pnlHeader.TabIndex = 51;
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMenu.FlatAppearance.BorderSize = 0;
            this.btnShowMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnShowMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowMenu.ForeColor = System.Drawing.Color.White;
            this.btnShowMenu.Location = new System.Drawing.Point(0, 0);
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(133, 54);
            this.btnShowMenu.TabIndex = 45;
            this.btnShowMenu.Text = "Menu";
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(214, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 42);
            this.label6.TabIndex = 38;
            this.label6.Text = "Product Management Page";
            // 
            // pnlIdProcess
            // 
            this.pnlIdProcess.Controls.Add(this.txtSearch);
            this.pnlIdProcess.Controls.Add(this.label7);
            this.pnlIdProcess.Controls.Add(this.btnFetch);
            this.pnlIdProcess.Controls.Add(this.btnDelete);
            this.pnlIdProcess.Location = new System.Drawing.Point(158, 72);
            this.pnlIdProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlIdProcess.Name = "pnlIdProcess";
            this.pnlIdProcess.Size = new System.Drawing.Size(589, 54);
            this.pnlIdProcess.TabIndex = 49;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(122, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetch.FlatAppearance.BorderSize = 0;
            this.btnFetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnFetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFetch.ForeColor = System.Drawing.Color.White;
            this.btnFetch.Location = new System.Drawing.Point(349, 12);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(97, 40);
            this.btnFetch.TabIndex = 37;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(458, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 44);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.flowLayoutPanel1);
            this.pnlDetails.Controls.Add(this.cmbCategory);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.txtStock);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.btnClear);
            this.pnlDetails.Controls.Add(this.btnAdd);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtPrice);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label);
            this.pnlDetails.Controls.Add(this.btnUpdate);
            this.pnlDetails.Controls.Add(this.txtBrand);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.txtDescription);
            this.pnlDetails.Location = new System.Drawing.Point(166, 130);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(562, 442);
            this.pnlDetails.TabIndex = 50;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(311, 95);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 31);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(114, 103);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(194, 21);
            this.cmbCategory.TabIndex = 39;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Stock :";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(114, 187);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(193, 26);
            this.txtStock.TabIndex = 38;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(114, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 26);
            this.txtID.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(8, 22);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 23);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Product ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(116, 381);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 48);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(232, 380);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 48);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(114, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 26);
            this.txtName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Price: ";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(114, 139);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 26);
            this.txtPrice.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Brand :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(20, 101);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 23);
            this.label.TabIndex = 33;
            this.label.Text = "Category :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(232, 381);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 47);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(114, 235);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBrand.MaxLength = 10;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(193, 26);
            this.txtBrand.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(114, 276);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(193, 74);
            this.txtDescription.TabIndex = 24;
            // 
            // btnVeiwAll
            // 
            this.btnVeiwAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVeiwAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeiwAll.FlatAppearance.BorderSize = 0;
            this.btnVeiwAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnVeiwAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVeiwAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiwAll.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeiwAll.ForeColor = System.Drawing.Color.White;
            this.btnVeiwAll.Location = new System.Drawing.Point(-10, 6);
            this.btnVeiwAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVeiwAll.Name = "btnVeiwAll";
            this.btnVeiwAll.Size = new System.Drawing.Size(143, 78);
            this.btnVeiwAll.TabIndex = 26;
            this.btnVeiwAll.Text = "All Products";
            this.btnVeiwAll.UseVisualStyleBackColor = false;
            this.btnVeiwAll.Click += new System.EventHandler(this.btnVeiwAll_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnCategoriesMenu);
            this.pnlMenu.Controls.Add(this.btnAddMenu);
            this.pnlMenu.Controls.Add(this.btnUpdateMenu);
            this.pnlMenu.Controls.Add(this.btnFetchMenu);
            this.pnlMenu.Controls.Add(this.btnDeleteMenu);
            this.pnlMenu.Controls.Add(this.btnVeiwAll);
            this.pnlMenu.Location = new System.Drawing.Point(8, 64);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 522);
            this.pnlMenu.TabIndex = 48;
            // 
            // btnCategoriesMenu
            // 
            this.btnCategoriesMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCategoriesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoriesMenu.FlatAppearance.BorderSize = 0;
            this.btnCategoriesMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnCategoriesMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCategoriesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesMenu.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesMenu.Location = new System.Drawing.Point(-5, 412);
            this.btnCategoriesMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCategoriesMenu.Name = "btnCategoriesMenu";
            this.btnCategoriesMenu.Size = new System.Drawing.Size(143, 80);
            this.btnCategoriesMenu.TabIndex = 45;
            this.btnCategoriesMenu.Text = "Manage Categories";
            this.btnCategoriesMenu.UseVisualStyleBackColor = false;
            this.btnCategoriesMenu.Click += new System.EventHandler(this.btnCategoryMenu_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMenu.FlatAppearance.BorderSize = 0;
            this.btnAddMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnAddMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMenu.ForeColor = System.Drawing.Color.White;
            this.btnAddMenu.Location = new System.Drawing.Point(-10, 89);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(143, 80);
            this.btnAddMenu.TabIndex = 44;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnUpdateMenu
            // 
            this.btnUpdateMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUpdateMenu.FlatAppearance.BorderSize = 0;
            this.btnUpdateMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMenu.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMenu.Location = new System.Drawing.Point(-10, 167);
            this.btnUpdateMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateMenu.Name = "btnUpdateMenu";
            this.btnUpdateMenu.Size = new System.Drawing.Size(143, 80);
            this.btnUpdateMenu.TabIndex = 43;
            this.btnUpdateMenu.Text = "Update";
            this.btnUpdateMenu.UseVisualStyleBackColor = false;
            this.btnUpdateMenu.Click += new System.EventHandler(this.btnUpdateMenu_Click);
            // 
            // btnFetchMenu
            // 
            this.btnFetchMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFetchMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetchMenu.FlatAppearance.BorderSize = 0;
            this.btnFetchMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnFetchMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFetchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFetchMenu.ForeColor = System.Drawing.Color.White;
            this.btnFetchMenu.Location = new System.Drawing.Point(-10, 326);
            this.btnFetchMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFetchMenu.Name = "btnFetchMenu";
            this.btnFetchMenu.Size = new System.Drawing.Size(143, 80);
            this.btnFetchMenu.TabIndex = 42;
            this.btnFetchMenu.Text = "Find";
            this.btnFetchMenu.UseVisualStyleBackColor = false;
            this.btnFetchMenu.Click += new System.EventHandler(this.btnFetchMenu_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMenu.FlatAppearance.BorderSize = 0;
            this.btnDeleteMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMenu.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMenu.Location = new System.Drawing.Point(-10, 247);
            this.btnDeleteMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(143, 80);
            this.btnDeleteMenu.TabIndex = 40;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(166, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 432);
            this.dataGridView1.TabIndex = 47;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.White;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryName.Location = new System.Drawing.Point(146, 76);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(193, 26);
            this.txtCategoryName.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Category Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Category ID :";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.Color.White;
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryID.Location = new System.Drawing.Point(146, 36);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(193, 26);
            this.txtCategoryID.TabIndex = 35;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(189, 132);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(110, 30);
            this.btnAddCategory.TabIndex = 36;
            this.btnAddCategory.Text = "Add ";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnListCategory
            // 
            this.btnListCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListCategory.FlatAppearance.BorderSize = 0;
            this.btnListCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnListCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListCategory.ForeColor = System.Drawing.Color.White;
            this.btnListCategory.Location = new System.Drawing.Point(189, 249);
            this.btnListCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnListCategory.Name = "btnListCategory";
            this.btnListCategory.Size = new System.Drawing.Size(110, 50);
            this.btnListCategory.TabIndex = 37;
            this.btnListCategory.Text = "List All Categories";
            this.btnListCategory.UseVisualStyleBackColor = false;
            this.btnListCategory.Click += new System.EventHandler(this.btnListCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(189, 172);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(110, 30);
            this.btnUpdateCategory.TabIndex = 38;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(189, 210);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(110, 30);
            this.btnDeleteCategory.TabIndex = 39;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.btnDeleteCategory);
            this.pnlCategories.Controls.Add(this.btnUpdateCategory);
            this.pnlCategories.Controls.Add(this.btnListCategory);
            this.pnlCategories.Controls.Add(this.btnAddCategory);
            this.pnlCategories.Controls.Add(this.txtCategoryID);
            this.pnlCategories.Controls.Add(this.label8);
            this.pnlCategories.Controls.Add(this.label9);
            this.pnlCategories.Controls.Add(this.txtCategoryName);
            this.pnlCategories.Location = new System.Drawing.Point(150, 225);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(499, 318);
            this.pnlCategories.TabIndex = 42;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 570);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlIdProcess);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlIdProcess.ResumeLayout(false);
            this.pnlIdProcess.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlIdProcess;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnVeiwAll;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCategoriesMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnFetchMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnListCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Panel pnlCategories;
    }
}