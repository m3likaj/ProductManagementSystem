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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.btnInvoice = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlOrderID = new System.Windows.Forms.Panel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.pnlIdProcess.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCDetails.SuspendLayout();
            this.pnlFindCustomer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlOrderID.SuspendLayout();
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
            this.btnShowMenu.Location = new System.Drawing.Point(-11, 0);
            this.btnShowMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(188, 66);
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
            this.label6.Size = new System.Drawing.Size(527, 51);
            this.label6.TabIndex = 38;
            this.label6.Text = "Order Management Page";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(172, 25);
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
            this.label7.Location = new System.Drawing.Point(43, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search";
            // 
            // pnlIdProcess
            // 
            this.pnlIdProcess.Controls.Add(this.txtSearch);
            this.pnlIdProcess.Controls.Add(this.label7);
            this.pnlIdProcess.Controls.Add(this.btnFetch);
            this.pnlIdProcess.Location = new System.Drawing.Point(211, 90);
            this.pnlIdProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIdProcess.Name = "pnlIdProcess";
            this.pnlIdProcess.Size = new System.Drawing.Size(785, 66);
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
            this.btnFetch.Location = new System.Drawing.Point(484, 16);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(129, 49);
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
            this.btnManageOrder.Location = new System.Drawing.Point(-13, 110);
            this.btnManageOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(191, 98);
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
            this.pnlMenu.Location = new System.Drawing.Point(11, 79);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(180, 642);
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
            this.btnMakeOrder.Location = new System.Drawing.Point(-11, 7);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(191, 96);
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
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 66);
            this.pnlHeader.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(211, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 478);
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
            this.btnConfirm.Location = new System.Drawing.Point(165, 4);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 54);
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
            this.btnDone.Location = new System.Drawing.Point(318, 4);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(147, 54);
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
            this.btnBack.Location = new System.Drawing.Point(12, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 54);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(624, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 54);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.panel1);
            this.pnlAddCustomer.Controls.Add(this.btnGoToCustomerPage);
            this.pnlAddCustomer.Controls.Add(this.pnlCDetails);
            this.pnlAddCustomer.Controls.Add(this.pnlFindCustomer);
            this.pnlAddCustomer.Controls.Add(this.label2);
            this.pnlAddCustomer.Location = new System.Drawing.Point(273, 208);
            this.pnlAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(653, 407);
            this.pnlAddCustomer.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNew);
            this.panel1.Controls.Add(this.rbExisting);
            this.panel1.Location = new System.Drawing.Point(229, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 43);
            this.panel1.TabIndex = 47;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(177, 11);
            this.rbNew.Margin = new System.Windows.Forms.Padding(4);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(55, 20);
            this.rbNew.TabIndex = 43;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbExisting
            // 
            this.rbExisting.AutoSize = true;
            this.rbExisting.Location = new System.Drawing.Point(27, 11);
            this.rbExisting.Margin = new System.Windows.Forms.Padding(4);
            this.rbExisting.Name = "rbExisting";
            this.rbExisting.Size = new System.Drawing.Size(74, 20);
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
            this.btnGoToCustomerPage.Location = new System.Drawing.Point(19, 119);
            this.btnGoToCustomerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoToCustomerPage.Name = "btnGoToCustomerPage";
            this.btnGoToCustomerPage.Size = new System.Drawing.Size(609, 65);
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
            this.pnlCDetails.Location = new System.Drawing.Point(15, 149);
            this.pnlCDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCDetails.Name = "pnlCDetails";
            this.pnlCDetails.Size = new System.Drawing.Size(623, 255);
            this.pnlCDetails.TabIndex = 46;
            // 
            // lblCemail
            // 
            this.lblCemail.AutoSize = true;
            this.lblCemail.BackColor = System.Drawing.Color.Transparent;
            this.lblCemail.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCemail.ForeColor = System.Drawing.Color.Black;
            this.lblCemail.Location = new System.Drawing.Point(203, 154);
            this.lblCemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCemail.Name = "lblCemail";
            this.lblCemail.Size = new System.Drawing.Size(17, 27);
            this.lblCemail.TabIndex = 35;
            this.lblCemail.Text = " ";
            // 
            // lblCphone
            // 
            this.lblCphone.AutoSize = true;
            this.lblCphone.BackColor = System.Drawing.Color.Transparent;
            this.lblCphone.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCphone.ForeColor = System.Drawing.Color.Black;
            this.lblCphone.Location = new System.Drawing.Point(203, 114);
            this.lblCphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCphone.Name = "lblCphone";
            this.lblCphone.Size = new System.Drawing.Size(17, 27);
            this.lblCphone.TabIndex = 34;
            this.lblCphone.Text = " ";
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.BackColor = System.Drawing.Color.Transparent;
            this.lblCname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCname.ForeColor = System.Drawing.Color.Black;
            this.lblCname.Location = new System.Drawing.Point(203, 74);
            this.lblCname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(17, 27);
            this.lblCname.TabIndex = 33;
            this.lblCname.Text = " ";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.Transparent;
            this.lblCid.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCid.ForeColor = System.Drawing.Color.Black;
            this.lblCid.Location = new System.Drawing.Point(203, 33);
            this.lblCid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(17, 27);
            this.lblCid.TabIndex = 32;
            this.lblCid.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(101, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(32, 33);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(135, 27);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Customer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
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
            this.btnAddAndOrder.Location = new System.Drawing.Point(446, 187);
            this.btnAddAndOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAndOrder.Name = "btnAddAndOrder";
            this.btnAddAndOrder.Size = new System.Drawing.Size(173, 65);
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
            this.label4.Location = new System.Drawing.Point(63, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone No:";
            // 
            // pnlFindCustomer
            // 
            this.pnlFindCustomer.Controls.Add(this.txtFindCustomer);
            this.pnlFindCustomer.Controls.Add(this.label1);
            this.pnlFindCustomer.Controls.Add(this.btnFindCustomer);
            this.pnlFindCustomer.Location = new System.Drawing.Point(15, 65);
            this.pnlFindCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFindCustomer.Name = "pnlFindCustomer";
            this.pnlFindCustomer.Size = new System.Drawing.Size(623, 78);
            this.pnlFindCustomer.TabIndex = 45;
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.BackColor = System.Drawing.Color.White;
            this.txtFindCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtFindCustomer.Location = new System.Drawing.Point(172, 25);
            this.txtFindCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(257, 30);
            this.txtFindCustomer.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
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
            this.btnFindCustomer.Location = new System.Drawing.Point(484, 16);
            this.btnFindCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(129, 49);
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
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Add customer:";
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(471, 4);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(147, 54);
            this.btnInvoice.TabIndex = 52;
            this.btnInvoice.Text = "Create Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnInvoice);
            this.flowLayoutPanel1.Controls.Add(this.btnDone);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.btnBack);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 647);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 111);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Order ID: ";
            // 
            // pnlOrderID
            // 
            this.pnlOrderID.Controls.Add(this.lblOrderId);
            this.pnlOrderID.Controls.Add(this.label8);
            this.pnlOrderID.Location = new System.Drawing.Point(356, 83);
            this.pnlOrderID.Name = "pnlOrderID";
            this.pnlOrderID.Size = new System.Drawing.Size(280, 73);
            this.pnlOrderID.TabIndex = 54;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderId.ForeColor = System.Drawing.Color.Black;
            this.lblOrderId.Location = new System.Drawing.Point(132, 30);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(27, 29);
            this.lblOrderId.TabIndex = 40;
            this.lblOrderId.Text = ". ";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 706);
            this.Controls.Add(this.pnlOrderID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlAddCustomer);
            this.Controls.Add(this.pnlIdProcess);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlOrderID.ResumeLayout(false);
            this.pnlOrderID.PerformLayout();
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
        private System.Windows.Forms.Button btnCancel;
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
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlOrderID;
        private System.Windows.Forms.Label lblOrderId;
    }
}