﻿namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EndofEditforce : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
        }
    }
}
