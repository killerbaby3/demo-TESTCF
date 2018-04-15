namespace PM_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        price = c.Int(nullable: false),
                        supplier_supId = c.Int(),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.Suppliers", t => t.supplier_supId)
                .Index(t => t.supplier_supId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        supId = c.Int(nullable: false, identity: true),
                        supName = c.String(),
                        address = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.supId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "supplier_supId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "supplier_supId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
        }
    }
}
