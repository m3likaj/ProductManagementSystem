namespace ProductManagementSystem.PresentationLayer
{
    partial class FrmOrder
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
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlIdProcess = new System.Windows.Forms.Panel();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbExisting = new System.Windows.Forms.RadioButton();
            this.btnGoToCustomerPage = new System.Windows.Forms.Button();
            this.pnlCDetails = new System.Windows.Forms.Panel();
            this.lblCemail = new System.Windows.Forms.Label();
            this.lblCphone = new System.Windows.Forms.Label();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAndOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFindCustomer = new System.Windows.Forms.Panel();
            this.txtFindCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlIdProcess.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCDetails.SuspendLayout();
            this.pnlFindCustomer.SuspendLayout();
            this.SuspendLayout();
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
            this.btnShowMenu.Location = new System.Drawing.Point(-8, 0);
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(141, 54);
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
            this.label6.Location = new System.Drawing.Point(214, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 39);
            this.label6.TabIndex = 38;
            this.label6.Text = "Order Management Page";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(129, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 26);
            this.txtSearch.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // pnlIdProcess
            // 
            this.pnlIdProcess.Controls.Add(this.txtSearch);
            this.pnlIdProcess.Controls.Add(this.label7);
            this.pnlIdProcess.Controls.Add(this.btnFetch);
            this.pnlIdProcess.Location = new System.Drawing.Point(158, 73);
            this.pnlIdProcess.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIdProcess.Name = "pnlIdProcess";
            this.pnlIdProcess.Size = new System.Drawing.Size(589, 54);
            this.pnlIdProcess.TabIndex = 44;
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
            this.btnFetch.Location = new System.Drawing.Point(363, 13);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(97, 40);
            this.btnFetch.TabIndex = 37;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageOrder.FlatAppearance.BorderSize = 0;
            this.btnManageOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnManageOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManageOrder.ForeColor = System.Drawing.Color.White;
            this.btnManageOrder.Location = new System.Drawing.Point(-10, 89);
            this.btnManageOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(143, 80);
            this.btnManageOrder.TabIndex = 44;
            this.btnManageOrder.Text = "Manage Orders";
            this.btnManageOrder.UseVisualStyleBackColor = false;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnManageOrder);
            this.pnlMenu.Controls.Add(this.btnMakeOrder);
            this.pnlMenu.Location = new System.Drawing.Point(8, 64);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 522);
            this.pnlMenu.TabIndex = 43;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnMakeOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakeOrder.ForeColor = System.Drawing.Color.White;
            this.btnMakeOrder.Location = new System.Drawing.Point(-8, 6);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(143, 78);
            this.btnMakeOrder.TabIndex = 26;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.btnShowMenu);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Location = new System.Drawing.Point(9, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(738, 54);
            this.pnlHeader.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(158, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 388);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(622, 526);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 44);
            this.btnConfirm.TabIndex = 47;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(622, 526);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 44);
            this.btnDone.TabIndex = 48;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(491, 526);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 44);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(622, 526);
            this.btnManage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(110, 44);
            this.btnManage.TabIndex = 50;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = false;
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.panel1);
            this.pnlAddCustomer.Controls.Add(this.btnGoToCustomerPage);
            this.pnlAddCustomer.Controls.Add(this.pnlCDetails);
            this.pnlAddCustomer.Controls.Add(this.pnlFindCustomer);
            this.pnlAddCustomer.Controls.Add(this.label2);
            this.pnlAddCustomer.Location = new System.Drawing.Point(205, 169);
            this.pnlAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(490, 331);
            this.pnlAddCustomer.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNew);
            this.panel1.Controls.Add(this.rbExisting);
            this.panel1.Location = new System.Drawing.Point(172, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 47;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(133, 9);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(47, 17);
            this.rbNew.TabIndex = 43;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbExisting
            // 
            this.rbExisting.AutoSize = true;
            this.rbExisting.Location = new System.Drawing.Point(20, 9);
            this.rbExisting.Name = "rbExisting";
            this.rbExisting.Size = new System.Drawing.Size(61, 17);
            this.rbExisting.TabIndex = 42;
            this.rbExisting.TabStop = true;
            this.rbExisting.Text = "Existing";
            this.rbExisting.UseVisualStyleBackColor = true;
            this.rbExisting.CheckedChanged += new System.EventHandler(this.rbExisting_CheckedChanged);
            // 
            // btnGoToCustomerPage
            // 
            this.btnGoToCustomerPage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoToCustomerPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToCustomerPage.FlatAppearance.BorderSize = 0;
            this.btnGoToCustomerPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnGoToCustomerPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGoToCustomerPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToCustomerPage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToCustomerPage.ForeColor = System.Drawing.Color.White;
            this.btnGoToCustomerPage.Location = new System.Drawing.Point(14, 97);
            this.btnGoToCustomerPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoToCustomerPage.Name = "btnGoToCustomerPage";
            this.btnGoToCustomerPage.Size = new System.Drawing.Size(457, 53);
            this.btnGoToCustomerPage.TabIndex = 32;
            this.btnGoToCustomerPage.Text = "Go to Customer Management Page";
            this.btnGoToCustomerPage.UseVisualStyleBackColor = false;
            this.btnGoToCustomerPage.Click += new System.EventHandler(this.btnGoToCustomerPage_Click);
            // 
            // pnlCDetails
            // 
            this.pnlCDetails.Controls.Add(this.lblCemail);
            this.pnlCDetails.Controls.Add(this.lblCphone);
            this.pnlCDetails.Controls.Add(this.lblCname);
            this.pnlCDetails.Controls.Add(this.lblCid);
            this.pnlCDetails.Controls.Add(this.label5);
            this.pnlCDetails.Controls.Add(this.lblID);
            this.pnlCDetails.Controls.Add(this.label3);
            this.pnlCDetails.Controls.Add(this.btnAddAndOrder);
            this.pnlCDetails.Controls.Add(this.label4);
            this.pnlCDetails.Location = new System.Drawing.Point(11, 121);
            this.pnlCDetails.Name = "pnlCDetails";
            this.pnlCDetails.Size = new System.Drawing.Size(467, 207);
            this.pnlCDetails.TabIndex = 46;
            // 
            // lblCemail
            // 
            this.lblCemail.AutoSize = true;
            this.lblCemail.BackColor = System.Drawing.Color.Transparent;
            this.lblCemail.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCemail.ForeColor = System.Drawing.Color.Black;
            this.lblCemail.Location = new System.Drawing.Point(152, 125);
            this.lblCemail.Name = "lblCemail";
            this.lblCemail.Size = new System.Drawing.Size(14, 23);
            this.lblCemail.TabIndex = 35;
            this.lblCemail.Text = " ";
            // 
            // lblCphone
            // 
            this.lblCphone.AutoSize = true;
            this.lblCphone.BackColor = System.Drawing.Color.Transparent;
            this.lblCphone.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCphone.ForeColor = System.Drawing.Color.Black;
            this.lblCphone.Location = new System.Drawing.Point(152, 93);
            this.lblCphone.Name = "lblCphone";
            this.lblCphone.Size = new System.Drawing.Size(14, 23);
            this.lblCphone.TabIndex = 34;
            this.lblCphone.Text = " ";
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.BackColor = System.Drawing.Color.Transparent;
            this.lblCname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCname.ForeColor = System.Drawing.Color.Black;
            this.lblCname.Location = new System.Drawing.Point(152, 60);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(14, 23);
            this.lblCname.TabIndex = 33;
            this.lblCname.Text = " ";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCid.ForeColor = System.Drawing.Color.Black;
            this.lblCid.Location = new System.Drawing.Point(152, 27);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(14, 23);
            this.lblCid.TabIndex = 32;
            this.lblCid.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Full Name :";
            // 
            // btnAddAndOrder
            // 
            this.btnAddAndOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAndOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAndOrder.FlatAppearance.BorderSize = 0;
            this.btnAddAndOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnAddAndOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAndOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAndOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAndOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddAndOrder.Location = new System.Drawing.Point(304, 138);
            this.btnAddAndOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAndOrder.Name = "btnAddAndOrder";
            this.btnAddAndOrder.Size = new System.Drawing.Size(130, 53);
            this.btnAddAndOrder.TabIndex = 29;
            this.btnAddAndOrder.Text = "Add and Order";
            this.btnAddAndOrder.UseVisualStyleBackColor = false;
            this.btnAddAndOrder.Click += new System.EventHandler(this.btnAddAndOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone No:";
            // 
            // pnlFindCustomer
            // 
            this.pnlFindCustomer.Controls.Add(this.txtFindCustomer);
            this.pnlFindCustomer.Controls.Add(this.label1);
            this.pnlFindCustomer.Controls.Add(this.btnFindCustomer);
            this.pnlFindCustomer.Location = new System.Drawing.Point(11, 53);
            this.pnlFindCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFindCustomer.Name = "pnlFindCustomer";
            this.pnlFindCustomer.Size = new System.Drawing.Size(467, 63);
            this.pnlFindCustomer.TabIndex = 45;
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.BackColor = System.Drawing.Color.White;
            this.txtFindCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtFindCustomer.Location = new System.Drawing.Point(129, 20);
            this.txtFindCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(193, 26);
            this.txtFindCustomer.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFindCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindCustomer.FlatAppearance.BorderSize = 0;
            this.btnFindCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnFindCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFindCustomer.ForeColor = System.Drawing.Color.White;
            this.btnFindCustomer.Location = new System.Drawing.Point(363, 13);
            this.btnFindCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(97, 40);
            this.btnFindCustomer.TabIndex = 37;
            this.btnFindCustomer.Text = "Find";
            this.btnFindCustomer.UseVisualStyleBackColor = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Add customer:";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 574);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlIdProcess);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.pnlIdProcess.ResumeLayout(false);
            this.pnlIdProcess.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCDetails.ResumeLayout(false);
            this.pnlCDetails.PerformLayout();
            this.pnlFindCustomer.ResumeLayout(false);
            this.pnlFindCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlIdProcess;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAndOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGoToCustomerPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlFindCustomer;
        private System.Windows.Forms.TextBox txtFindCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Label lblCphone;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblCemail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbExisting;
    }
}