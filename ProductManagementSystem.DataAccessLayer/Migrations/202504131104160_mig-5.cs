namespace ProductManagementSystem.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderStatus", c => c.String(nullable: false));
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            AlterColumn("dbo.Orders", "OrderStatus", c => c.String());
            DropColumn("dbo.Orders", "CustomerID");
        }
    }
}
