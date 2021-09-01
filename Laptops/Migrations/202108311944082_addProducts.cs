namespace Laptops.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDesc = c.String(),
                        Manufacturer = c.String(),
                        ProductPrice = c.Int(nullable: false),
                        Relas_Deate = c.DateTime(nullable: false),
                        Product_Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorys", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categorys");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
        }
    }
}
