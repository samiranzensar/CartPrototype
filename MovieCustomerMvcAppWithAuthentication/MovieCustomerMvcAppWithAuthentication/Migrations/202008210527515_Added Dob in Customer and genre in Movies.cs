namespace MovieCustomerMvcAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDobinCustomerandgenreinMovies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DOB", c => c.String());
        }
    }
}
