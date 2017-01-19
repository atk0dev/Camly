namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], 
                                 [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], 
                                 [AccessFailedCount], [UserName]) 
VALUES (N'101a29a6-8e5c-428f-be6a-ba1a3806ba4c', N'admin@camly.com', 0, 
        N'AFaeBqbbl5QLa894w0mR4Yj73VkDov9s9PJtpuoAENOOhOFODpHvwZ+wDDu72Sk5FQ==', N'436d530e-f8e7-4111-b7ca-f1bf8bcf34a7', 
        NULL, 0, 0, NULL, 1, 0, N'admin@camly.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], 
                                 [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], 
                                 [AccessFailedCount], [UserName]) 
VALUES (N'99f66d5d-27a1-44bd-8661-af88bbf67ef3', N'guest@camly.com', 0, 
        N'AIBgjKtDJErTVjdrdmgknpGNCHdtW//mq5/AO06ao+O/iMdVCMjs9pOrbSal4TEWVA==', N'48613ece-8665-45f6-8161-333438ad3d2b', 
        NULL, 0, 0, NULL, 1, 0, N'guest@camly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'101a29a6-8e5c-428f-be6a-ba1a3806ba4c', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }
        
        public override void Down()
        {
        }
    }
}
