namespace NewApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelforce : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 255),
                        IsSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipTypeId = c.Byte(nullable: false),
                        BirthDate = c.DateTime(),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MembershipName = c.String(),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Customers", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
