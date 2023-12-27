namespace NewApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersforce : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19e604f3-eb15-4a50-9f19-cbc25e4e5724', N'admin@moviepoint.com', 0, N'AGaZpJuaMY431AgbfgZB6L3iDePhi3lYNhgTIjxOSS5ChUddJPFZSL0qC8TZoKE6Ow==', N'97715725-ab66-4416-82ff-d647729e418f', NULL, 0, 0, NULL, 1, 0, N'admin@moviepoint.com')

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f723c1d8-8d5e-4bbd-acae-98a30fabbf6e', N'adnan@ak.com', 0, N'AMgeTMcWxIafw833QNfJQVcIQWtH+pzUb171YpVkNack7b6167qZDdj0eNP/FCsZww==', N'f575a384-ff54-4254-9655-1710fb4572e1', NULL, 0, 0, NULL, 1, 0, N'adnan@ak.com')
                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2d30265b-afd9-4b3e-a6fe-773e8e662814', N'CanChangeMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'19e604f3-eb15-4a50-9f19-cbc25e4e5724', N'2d30265b-afd9-4b3e-a6fe-773e8e662814')


");
        }
        
        public override void Down()
        {
        }
    }
}
