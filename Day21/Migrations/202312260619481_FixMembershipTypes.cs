namespace NewApp.Migrations
{
    using NewApp.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Free Trial' WHERE Id = 1");
            Sql("UPDATE  MembershipTypes SET MembershipName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE  MembershipTypes SET MembershipName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE  MembershipTypes SET MembershipName = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
