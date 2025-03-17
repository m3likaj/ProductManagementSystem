namespace ProductManagementSystem.PresentationLayer
{
    partial class FrmCategory
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
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlIdProcess = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnUpdateMenu = new System.Windows.Forms.Button();
            this.btnFetchMenu = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnVeiwAll = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlIdProcess.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.btnClear);
            this.pnlCategories.Controls.Add(this.btnUpdateCategory);
            this.pnlCategories.Controls.Add(this.btnAddCategory);
            this.pnlCategories.Controls.Add(this.txtCategoryID);
            this.pnlCategories.Controls.Add(this.label8);
            this.pnlCategories.Controls.Add(this.label9);
            this.pnlCategories.Controls.Add(this.txtCategoryName);
            this.pnlCategories.Location = new System.Drawing.Point(253, 212);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(665, 391);
            this.pnlCategories.TabIndex = 52;
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
            this.btnClear.Location = new System.Drawing.Point(97, 212);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 59);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnUpdateCategory.Location = new System.Drawing.Point(252, 223);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(147, 37);
            this.btnUpdateCategory.TabIndex = 38;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
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
            this.btnAddCategory.Location = new System.Drawing.Point(252, 223);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(147, 37);
            this.btnAddCategory.TabIndex = 36;
            this.btnAddCategory.Text = "Add ";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.Color.White;
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryID.Location = new System.Drawing.Point(235, 43);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(257, 30);
            this.txtCategoryID.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Category ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Category Name :";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.White;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryName.Location = new System.Drawing.Point(235, 94);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(257, 30);
            this.txtCategoryName.TabIndex = 33;
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
            this.dataGridView1.Location = new System.Drawing.Point(216, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 544);
            this.dataGridView1.TabIndex = 48;
            // 
            // pnlIdProcess
            // 
            this.pnlIdProcess.Controls.Add(this.txtSearch);
            this.pnlIdProcess.Controls.Add(this.label7);
            this.pnlIdProcess.Controls.Add(this.btnFetch);
            this.pnlIdProcess.Controls.Add(this.btnDelete);
            this.pnlIdProcess.Location = new System.Drawing.Point(203, 78);
            this.pnlIdProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIdProcess.Name = "pnlIdProcess";
            this.pnlIdProcess.Size = new System.Drawing.Size(785, 66);
            this.pnlIdProcess.TabIndex = 55;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(184, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 30);
            this.txtSearch.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
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
            this.btnFetch.Location = new System.Drawing.Point(465, 15);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(129, 49);
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
            this.btnDelete.Location = new System.Drawing.Point(611, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 54);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnAddMenu);
            this.pnlMenu.Controls.Add(this.btnUpdateMenu);
            this.pnlMenu.Controls.Add(this.btnFetchMenu);
            this.pnlMenu.Controls.Add(this.btnDeleteMenu);
            this.pnlMenu.Controls.Add(this.btnVeiwAll);
            this.pnlMenu.Location = new System.Drawing.Point(3, 68);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(180, 642);
            this.pnlMenu.TabIndex = 54;
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
            this.btnAddMenu.Location = new System.Drawing.Point(-13, 110);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(191, 98);
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
            this.btnUpdateMenu.Location = new System.Drawing.Point(-13, 206);
            this.btnUpdateMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateMenu.Name = "btnUpdateMenu";
            this.btnUpdateMenu.Size = new System.Drawing.Size(191, 98);
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
            this.btnFetchMenu.Location = new System.Drawing.Point(-13, 401);
            this.btnFetchMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFetchMenu.Name = "btnFetchMenu";
            this.btnFetchMenu.Size = new System.Drawing.Size(191, 98);
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
            this.btnDeleteMenu.Location = new System.Drawing.Point(-13, 304);
            this.btnDeleteMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(191, 98);
            this.btnDeleteMenu.TabIndex = 40;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
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
            this.btnVeiwAll.Location = new System.Drawing.Point(-13, 7);
            this.btnVeiwAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVeiwAll.Name = "btnVeiwAll";
            this.btnVeiwAll.Size = new System.Drawing.Size(191, 96);
            this.btnVeiwAll.TabIndex = 26;
            this.btnVeiwAll.Text = "All Categories";
            this.btnVeiwAll.UseVisualStyleBackColor = false;
            this.btnVeiwAll.Click += new System.EventHandler(this.btnVeiwAll_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.btnShowMenu);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Location = new System.Drawing.Point(3, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 66);
            this.pnlHeader.TabIndex = 57;
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
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(177, 66);
            this.btnShowMenu.TabIndex = 45;
            this.btnShowMenu.Text = "Menu";
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(285, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 51);
            this.label6.TabIndex = 38;
            this.label6.Text = "Category Management Page";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 738);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlIdProcess);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlIdProcess.ResumeLayout(false);
            this.pnlIdProcess.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Panel pnlIdProcess;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnFetchMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnVeiwAll;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

