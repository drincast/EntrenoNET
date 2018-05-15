namespace mvctest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_isSubcribedToNewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubcribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSubcribedToNewsletter");
        }
    }
}
