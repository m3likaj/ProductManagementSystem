namespace ProductManagementSystem.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "OrderStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "OrderStatus", c => c.Int(nullable: false));
        }
    }
}
