namespace SupplierManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changsSupplier : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sys_Supplier");
            AddColumn("dbo.Sys_Supplier", "SupplierCode", c => c.String(nullable: false, maxLength: 6));
            AddPrimaryKey("dbo.Sys_Supplier", "SupplierCode");
            DropColumn("dbo.Sys_Supplier", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sys_Supplier", "Id", c => c.String(nullable: false, maxLength: 6));
            DropPrimaryKey("dbo.Sys_Supplier");
            DropColumn("dbo.Sys_Supplier", "SupplierCode");
            AddPrimaryKey("dbo.Sys_Supplier", "Id");
        }
    }
}
