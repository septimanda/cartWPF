namespace CartWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelCartWPF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stock = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        isDelete = c.Boolean(nullable: false),
                        Suppliers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Suppliers_Id)
                .Index(t => t.Suppliers_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        JoinDate = c.DateTimeOffset(nullable: false, precision: 7),
                        isDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JoinDate = c.DateTimeOffset(nullable: false, precision: 7),
                        isDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransactionItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        isDelete = c.Boolean(nullable: false),
                        Items_Id = c.Int(),
                        Sells_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Items_Id)
                .ForeignKey("dbo.Sells", t => t.Sells_Id)
                .Index(t => t.Items_Id)
                .Index(t => t.Sells_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "Sells_Id", "dbo.Sells");
            DropForeignKey("dbo.TransactionItems", "Items_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "Suppliers_Id", "dbo.Suppliers");
            DropIndex("dbo.TransactionItems", new[] { "Sells_Id" });
            DropIndex("dbo.TransactionItems", new[] { "Items_Id" });
            DropIndex("dbo.Items", new[] { "Suppliers_Id" });
            DropTable("dbo.TransactionItems");
            DropTable("dbo.Sells");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Items");
        }
    }
}
