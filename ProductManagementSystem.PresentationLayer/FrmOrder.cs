using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using ProductManagementSystem.BusinessLayer;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.EntityLayer.Concrete;


namespace ProductManagementSystem.PresentationLayer
{
    public partial class FrmOrder : Form
    {
        ProductManager productManager;
        OrderManager orderManager;
        Context context;
        CustomerManager customerManager;
        InvoiceManager invoiceManager;
        private Dictionary<int, int> productQuantities = new Dictionary<int, int>();
        bool MakeOrder = true;
        Order order;

        public FrmOrder()
        {
            context = new Context();
            productManager = new ProductManager(context);
            orderManager = new OrderManager(context);
            customerManager = new CustomerManager(context);
            invoiceManager = new InvoiceManager(context);
            InitializeComponent();

        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = productManager.getProductsWithPrice();
            dataGridView1.Visible = true;
            pnlAddCustomer.Visible = false;
            btnMakeOrder_Click(sender, e);
        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            if (MakeOrder)
            {
                Product product = null;
                int.TryParse(txtSearch.Text, out int id);
                product = productManager.Get(id);

                if (product == null)
                {
                    var products = productManager.GetProductsByName(txtSearch.Text, false);

                    if (products.Count() == 0)
                    {
                        products = productManager.GetProductsByCategory(txtSearch.Text, false);
                    }
                    if (products.Count() == 0)
                    {
                        MessageBox.Show("Product not found");
                        return;
                    }
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = products;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                    btnDone.Visible = true;
                    return;
                }

                else
                {
                    var p = new
                    {
                        ProductID = product.ProductId,
                        Name = product.Name,
                        Price = product.Price
                    };
                    List<object> productList = new List<object>() { p };
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = productList;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                }
            }
            else
            {
                Order o = null;
                int.TryParse(txtSearch.Text, out int id);
                o = orderManager.Get(id);
                if (o == null)
                {
                    var values = orderManager.GetOrderByCustomer(txtSearch.Text);

                    if (values.Count() == 0)
                    {
                        values = orderManager.GetOrderByStatus(txtSearch.Text);
                    }
                    if (values.Count() == 0)
                    {
                        MessageBox.Show("Order not found");
                        return;
                    }
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = values;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();
                    btnDone.Visible = true;
                    return;
                }
                else
                {
                    var retrievedOrder = new
                    {
                        OrderID = o.OrderId,
                        Customer = o.Customer.Name + " " + o.Customer.Surname,
                        Products = (o.OrderProducts.Count() > 0) ? orderManager.getProducts(o.OrderProducts) : "no products",// Works in memory
                        Price = o.TotalPrice,
                        Status = o.OrderStatus
                    };
                    var orderList = new List<object> { retrievedOrder };
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = orderList;
                    dataGridView1.Visible = true;
                    add_columns_to_grid();

                }
            }

        }


        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrder = true;
            pnlOrderID.Visible = false;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid(); // Add quantity and buttons again
            btnConfirm.Visible = false;
            btnDone.Visible = true;
            btnBack.Visible = false;
            btnCancel.Visible = false;
            pnlIdProcess.Visible = true;
            btnInvoice.Visible = false;
            pnlAddCustomer.Visible = false;
            dataGridView1.Visible = true; // Show the DataGridView
        }

        private void add_columns_to_grid()
        {
            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            if (MakeOrder)
            {
                DataGridViewButtonColumn buttonColumnAdd = new DataGridViewButtonColumn
                {
                    HeaderText = "Add",
                    Name = "btnAddProduct",
                    UseColumnTextForButtonValue = false  // Allows setting text per cell
                };
                DataGridViewButtonColumn buttonColumnRemove = new DataGridViewButtonColumn
                {
                    HeaderText = "Remove",
                    Name = "btnRemoveProduct",
                    UseColumnTextForButtonValue = false  // Allows setting text per cell
                };

                dataGridView1.Columns.Add("Quantity", "Quantity"); // Add Quantity column
                dataGridView1.Columns.Add(buttonColumnAdd); // Add button column
                dataGridView1.Columns.Add(buttonColumnRemove); // Add button column

                // Initialize rows with default values
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    if (productQuantities.TryGetValue(productId, out int savedQty))
                    {
                        row.Cells["Quantity"].Value = savedQty;
                    }
                    else
                    {
                        row.Cells["Quantity"].Value = 0;
                    }

                    row.Cells["btnAddProduct"].Value = "Add"; // Set initial button text
                    row.Cells["btnRemoveProduct"].Value = "Remove";
                }
            }
            else
            {
                DataGridViewButtonColumn buttonColumnManage = new DataGridViewButtonColumn
                {
                    HeaderText = "Details",
                    Name = "btnOrderDetails",
                    UseColumnTextForButtonValue = false  // Allows setting text per cell
                };

                dataGridView1.Columns.Add(buttonColumnManage); // Add button column
                                                               // Initialize rows with default values
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["btnOrderDetails"].Value = "Details";
                }
            }

            // Subscribe to events
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked within valid bounds
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int quantity;
                int productId;
                // Check if the clicked cell is the button column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnAddProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                    productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    Product product = productManager.Get(productId);
                    if (product.Stock <= quantity)
                    {
                        MessageBox.Show("there is no more" + product.Name + "in stock");
                    }
                    else
                    {

                        quantity++;
                        productQuantities[productId] = quantity;
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnRemoveProduct")
                {
                    // Get the quantity value
                    quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);

                    if (quantity > 0)
                    {
                        quantity--;
                        dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = quantity;
                        productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                        productQuantities[productId] = quantity;
                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be less than 0");
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnOrderDetails")
                {

                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    lblOrderId.Text = id.ToString();
                    dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
                    dataGridView1.DataSource = orderManager.GetOrderDetails(id);
                    btnBack.Visible = true;
                    pnlIdProcess.Visible = false;
                    pnlOrderID.Visible = true;
                    if (orderManager.Get(id).OrderStatus == "Canceled")
                    {
                        btnCancel.Visible = false;
                        btnInvoice.Visible = false;
                    }
                    else
                    {
                        btnCancel.Visible = true;
                        btnInvoice.Visible = true;
                    }
                }
                dataGridView1.Refresh();
            }
        }




        private void btnConfirm_Click(object sender, EventArgs e)
        {
            order = new Order
            {
                OrderProducts = new List<OrderProduct>(),
                TotalPrice = 0,
                OrderStatus = "Pending"
            };

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty);
                if (qty <= 0) continue;// Skip if quantity is not valid
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                Product product = productManager.Get(productId);


                order.OrderProducts.Add(new OrderProduct
                {
                    OrderID = order.OrderId,
                    ProductID = product.ProductId,
                    Quantity = qty,

                });
                order.TotalPrice += product.Price * qty;

            }
            if (order.OrderProducts.Count > 0)
            {
                dataGridView1.Visible = false;
                pnlAddCustomer.Visible = true;
                pnlCDetails.Visible = false;
                pnlFindCustomer.Visible = false;
                btnGoToCustomerPage.Visible = false;
                btnConfirm.Visible = false;
                btnBack.Visible = true;
                txtFindCustomer.Text = "";
                txtSearch.Text = "";
                rbExisting.Checked = false;
                rbNew.Checked = false;
            }
            else
            {
                MessageBox.Show("No products selected.");
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            var filtered = new List<(Product product, int quantity)>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Quantity"].Value != null &&
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty) &&
                    qty > 0)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    Product product = productManager.Get(productId);

                    if (product != null)
                        filtered.Add((product, qty));
                }
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show("No products Selected");
                return;
            }

            // Rebind filtered product list
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = filtered.Select(x => new
            {
                ProductID = x.product.ProductId,
                Name = x.product.Name,
                Price = x.product.Price
            }).ToList();

            add_columns_to_grid();

            // Restore quantity values
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                int qty = filtered.First(x => x.product.ProductId == productId).quantity;

                row.Cells["Quantity"].Value = qty;
                row.Cells["btnAddProduct"].Value = "Add";
                row.Cells["btnRemoveProduct"].Value = "Remove";
            }

            btnConfirm.Visible = true;
            btnDone.Visible = false;
            btnBack.Visible = true;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MakeOrder)
            {
                btnMakeOrder_Click(sender, e);
            }
            else
            {
                btnManageOrders_Click(sender, e);
            }
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            pnlOrderID.Visible = false;
            MakeOrder = false;
            btnDone.Visible = false;
            btnBack.Visible = false;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            pnlIdProcess.Visible = true;
            btnInvoice.Visible = false;
            pnlAddCustomer.Visible = false;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            dataGridView1.DataSource = orderManager.GetOrders();
            add_columns_to_grid(); // Add details button
            dataGridView1.Visible = true; // Show the DataGridView

        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            int.TryParse(txtFindCustomer.Text, out int id);
            Customer customer = null;
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
                MessageBox.Show("Customer not Found");
            }
            else
            {
                pnlCDetails.Visible = true;
                lblCid.Text = customer.CustomerID.ToString();
                lblCemail.Text = customer.Email;
                lblCname.Text = customer.Name;
                lblCphone.Text = customer.PhoneNumber;
            }
        }

        private void btnGoToCustomerPage_Click(object sender, EventArgs e)
        {
            var customerForm = new FrmCustomer();
            customerForm.Show();
        }

        private void btnAddAndOrder_Click(object sender, EventArgs e)
        {
            int.TryParse(lblCid.Text, out int id);
            Customer customer = customerManager.Get(id);
            order.CustomerID = id;

            foreach (var item in order.OrderProducts)
            {
                Product product = productManager.Get(item.ProductID);
                product.Stock -= item.Quantity;
                productManager.Update(product);
            }
            context.Orders.Add(order);
            context.SaveChanges();
            MessageBox.Show("Order confirmed!");

            // Reset grid
            pnlAddCustomer.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.Columns.Clear(); // Clear old columns to prevent duplication
            productQuantities.Clear();
            dataGridView1.DataSource = productManager.getProductsWithPrice();
            add_columns_to_grid(); // Add quantity and buttons again
            btnMakeOrder_Click(sender, e);

        }

        private void rbExisting_CheckedChanged(object sender, EventArgs e)
        {
            pnlFindCustomer.Visible = true;
            pnlCDetails.Visible = false;
            btnGoToCustomerPage.Visible = false;
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            btnGoToCustomerPage.Visible = true;
            pnlFindCustomer.Visible = false;
            pnlCDetails.Visible = false;
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            var menuForm = new FrmMenu();
            menuForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the order?",
                                      "Confirm Cancellation",
                                      MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Order canceled = orderManager.Get(Convert.ToInt32(lblOrderId.Text));
                canceled.OrderStatus = "Canceled";
                foreach (var item in canceled.OrderProducts)
                {
                    Product product = productManager.Get(item.ProductID);
                    product.Stock += item.Quantity;
                    productManager.Update(product);
                }
                orderManager.Update(canceled);
                MessageBox.Show("Order Canceled");
                btnCancel.Visible = false;
                btnInvoice.Visible = false;
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Order invoicedOrder = orderManager.Get(Convert.ToInt32(lblOrderId.Text));
            Invoice invoice;
            if (invoicedOrder.OrderStatus == "Invoiced")
            {
                invoice =  invoiceManager.GetByOrder(invoicedOrder.OrderId);
            }
            else
            {
                invoicedOrder.OrderStatus = "Invoiced";
                orderManager.Update(invoicedOrder);
                invoice = new Invoice
                {
                    OrderID = invoicedOrder.OrderId,
                    CustomerID = invoicedOrder.CustomerID,
                    TotalPrice = invoicedOrder.TotalPrice,
                    InvoiceDate = DateTime.Now
                };
                invoiceManager.Add(invoice);
            }
            string folderPath = @"C:\Users\Biriz Teknoloji\source\repos\m3likaj\ProductManagementSystem\ProductManagementSystem.PresentationLayer\Invoices";
            string filePath = Path.Combine(folderPath, $"Invoice_{invoice.InvoiceID}.pdf"); // ✅ valid file path
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document doc = new Document(pdf);
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);


                    // Title
                    Paragraph header = new Paragraph("Invoice")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20)
                        .SetFont(boldFont);
                    doc.Add(header);

                    // Customer details
                    doc.Add(new Paragraph($"Customer: {invoicedOrder.Customer.Name}"));
                    doc.Add(new Paragraph($"Date: {invoice.InvoiceDate:yyyy-MM-dd}"));
                    doc.Add(new Paragraph(" ")); // empty space

                    // Table
                    Table table = new Table(2).UseAllAvailableWidth();
                    table.AddHeaderCell("Item");
                    table.AddHeaderCell("Price");
                    decimal total = 0;
                    foreach (var item in invoicedOrder.OrderProducts)
                    {
                        Product product = productManager.Get(item.ProductID);
                        decimal price = product.Price * item.Quantity;
                        string itemName = product.Name;
                        table.AddCell(itemName);
                        table.AddCell(price.ToString("C")); // format as currency
                        total += price;
                    }

                    // Total row
                    table.AddCell(new Cell(1, 1).Add(new Paragraph("Total")).SetFont(boldFont));
                    table.AddCell(total.ToString("C"));

                    doc.Add(table);

                    doc.Close();
                }
            }
            MessageBox.Show("Invoice PDF created successfully!");
            
        }
    }
}



