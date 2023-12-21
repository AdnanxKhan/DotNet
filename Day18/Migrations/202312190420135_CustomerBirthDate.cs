namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
            Sql("UPDATE Customers SET BirthDate = '2001-06-20' WHERE CustomerId = 2");
            Sql("UPDATE Customers SET BirthDate = '2000-07-21' WHERE CustomerId = 1");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
