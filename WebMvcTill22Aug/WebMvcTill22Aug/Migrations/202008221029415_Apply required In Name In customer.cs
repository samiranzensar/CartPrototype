namespace WebMvcTill22Aug.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyrequiredInNameIncustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CName", c => c.String());
        }
    }
}
