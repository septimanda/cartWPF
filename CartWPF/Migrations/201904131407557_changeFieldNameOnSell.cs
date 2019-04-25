namespace CartWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeFieldNameOnSell : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sells", "OrderDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Sells", "JoinDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sells", "JoinDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Sells", "OrderDate");
        }
    }
}
