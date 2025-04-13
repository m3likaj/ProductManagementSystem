namespace ProductManagementSystem.PresentationLayer
{
    partial class FrmCustomer
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnVeiwAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnOrdersHistory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHistoryMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnUpdateMenu = new System.Windows.Forms.Button();
            this.btnFetchMenu = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.pnlIdProcess = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlIdProcess.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(165, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(257, 26);
            this.txtID.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(24, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(112, 23);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Customer ID :";
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
            this.btnAdd.Location = new System.Drawing.Point(242, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 53);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(580, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 54);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(242, 336);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 52);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnVeiwAll.Location = new System.Drawing.Point(0, 8);
            this.btnVeiwAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVeiwAll.Name = "btnVeiwAll";
            this.btnVeiwAll.Size = new System.Drawing.Size(191, 96);
            this.btnVeiwAll.TabIndex = 26;
            this.btnVeiwAll.Text = "All Customers";
            this.btnVeiwAll.UseVisualStyleBackColor = false;
            this.btnVeiwAll.Click += new System.EventHandler(this.btnVeiwAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(212, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 532);
            this.dataGridView1.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(165, 281);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 26);
            this.txtAddress.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(165, 221);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 26);
            this.txtPhone.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(165, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(82, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(165, 76);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(257, 26);
            this.txtFirstName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name :";
            // 
            // txtSurName
            // 
            this.txtSurName.BackColor = System.Drawing.Color.White;
            this.txtSurName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurName.ForeColor = System.Drawing.Color.Black;
            this.txtSurName.Location = new System.Drawing.Point(165, 119);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(257, 26);
            this.txtSurName.TabIndex = 34;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(44, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 23);
            this.label.TabIndex = 33;
            this.label.Text = "Sur Name :";
            // 
            // btnOrdersHistory
            // 
            this.btnOrdersHistory.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdersHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdersHistory.FlatAppearance.BorderSize = 0;
            this.btnOrdersHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnOrdersHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOrdersHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrdersHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrdersHistory.Location = new System.Drawing.Point(569, 12);
            this.btnOrdersHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrdersHistory.Name = "btnOrdersHistory";
            this.btnOrdersHistory.Size = new System.Drawing.Size(181, 52);
            this.btnOrdersHistory.TabIndex = 35;
            this.btnOrdersHistory.Text = "View Order History";
            this.btnOrdersHistory.UseVisualStyleBackColor = false;
            this.btnOrdersHistory.Click += new System.EventHandler(this.ViewOrders_Click);
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
            this.btnClear.Location = new System.Drawing.Point(87, 336);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 53);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnFetch.Location = new System.Drawing.Point(434, 15);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(129, 49);
            this.btnFetch.TabIndex = 37;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnHistoryMenu);
            this.pnlMenu.Controls.Add(this.btnAddMenu);
            this.pnlMenu.Controls.Add(this.btnUpdateMenu);
            this.pnlMenu.Controls.Add(this.btnFetchMenu);
            this.pnlMenu.Controls.Add(this.btnDeleteMenu);
            this.pnlMenu.Controls.Add(this.btnVeiwAll);
            this.pnlMenu.Location = new System.Drawing.Point(1, 68);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(180, 642);
            this.pnlMenu.TabIndex = 38;
            // 
            // btnHistoryMenu
            // 
            this.btnHistoryMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHistoryMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoryMenu.FlatAppearance.BorderSize = 0;
            this.btnHistoryMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnHistoryMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHistoryMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryMenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistoryMenu.ForeColor = System.Drawing.Color.White;
            this.btnHistoryMenu.Location = new System.Drawing.Point(-4, 507);
            this.btnHistoryMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistoryMenu.Name = "btnHistoryMenu";
            this.btnHistoryMenu.Size = new System.Drawing.Size(191, 98);
            this.btnHistoryMenu.TabIndex = 45;
            this.btnHistoryMenu.Text = "View Order History";
            this.btnHistoryMenu.UseVisualStyleBackColor = false;
            this.btnHistoryMenu.Click += new System.EventHandler(this.btnHistoryMenu_Click);
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
            this.btnAddMenu.Location = new System.Drawing.Point(0, 110);
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
            this.btnUpdateMenu.Location = new System.Drawing.Point(0, 206);
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
            this.btnFetchMenu.Location = new System.Drawing.Point(-1, 401);
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
            this.btnDeleteMenu.Location = new System.Drawing.Point(0, 304);
            this.btnDeleteMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(191, 98);
            this.btnDeleteMenu.TabIndex = 40;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // pnlIdProcess
            // 
            this.pnlIdProcess.Controls.Add(this.txtSearch);
            this.pnlIdProcess.Controls.Add(this.label7);
            this.pnlIdProcess.Controls.Add(this.btnFetch);
            this.pnlIdProcess.Controls.Add(this.btnDelete);
            this.pnlIdProcess.Controls.Add(this.btnOrdersHistory);
            this.pnlIdProcess.Location = new System.Drawing.Point(201, 78);
            this.pnlIdProcess.Name = "pnlIdProcess";
            this.pnlIdProcess.Size = new System.Drawing.Size(785, 67);
            this.pnlIdProcess.TabIndex = 39;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(148, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 26);
            this.txtSearch.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(55, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.txtSurName);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.btnClear);
            this.pnlDetails.Controls.Add(this.btnAdd);
            this.pnlDetails.Controls.Add(this.txtFirstName);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label);
            this.pnlDetails.Controls.Add(this.btnUpdate);
            this.pnlDetails.Controls.Add(this.txtPhone);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.txtAddress);
            this.pnlDetails.Location = new System.Drawing.Point(212, 151);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(494, 394);
            this.pnlDetails.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(308, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 42);
            this.label6.TabIndex = 38;
            this.label6.Text = "Customer Management Page";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.btnShowMenu);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Location = new System.Drawing.Point(2, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 67);
            this.pnlHeader.TabIndex = 41;
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
            this.btnShowMenu.Location = new System.Drawing.Point(2, 0);
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(177, 67);
            this.btnShowMenu.TabIndex = 45;
            this.btnShowMenu.Text = "Menu";
            this.btnShowMenu.UseVisualStyleBackColor = false;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(998, 727);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlIdProcess);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlIdProcess.ResumeLayout(false);
            this.pnlIdProcess.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnVeiwAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnOrdersHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnFetchMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Panel pnlIdProcess;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnHistoryMenu;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFetch;
    }
}