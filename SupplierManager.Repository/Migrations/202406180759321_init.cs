namespace SupplierManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sys_Supplier",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 6),
                        Name = c.String(nullable: false, maxLength: 10),
                        Abbreviation = c.String(maxLength: 10),
                        TypeCode = c.String(nullable: false, maxLength: 2),
                        Province = c.String(maxLength: 8),
                        City = c.String(maxLength: 8),
                        Address = c.String(maxLength: 20),
                        Remark = c.String(maxLength: 50),
                        IsValue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sys_SupplierType",
                c => new
                    {
                        TypeCode = c.String(nullable: false, maxLength: 6),
                        TypeName = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.TypeCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sys_SupplierType");
            DropTable("dbo.Sys_Supplier");
        }
    }
}
