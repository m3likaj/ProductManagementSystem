namespace ProductManagementSystem.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 150),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvoiceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    Quantity = c.Int(nullable: false),
                    TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),

                })
                .PrimaryKey(t => t.OrderId);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    ProductId = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Stock = c.Int(nullable: false),
                    Description = c.String(nullable: false, maxLength: 300),
                    CategoryId = c.Int(nullable: false),
                    BrandId = c.Int(),
                })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)

                .Index(t => t.CategoryId)
                .Index(t => t.BrandId);
                
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        InvoiceID = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerID = c.Int(nullable: false),
                        PaymentStatus = c.Int(nullable: false),
                        PaymentFormat = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .Index(t => t.InvoiceID)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Payments", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Invoice_InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Products", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Payments", new[] { "CustomerID" });
            DropIndex("dbo.Payments", new[] { "InvoiceID" });
            DropIndex("dbo.Products", new[] { "Order_OrderId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Orders", new[] { "Invoice_InvoiceID" });
            DropTable("dbo.Payments");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
