namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a69b4f7-844f-4f24-95b8-a54b22388bcd', N'admin@mbsvidly.com', 0, N'AHU1C3eUdQsNM1CRSvSQfiOmvgGPtu73aydv+2TEOLE3Dyos5rdWkIG5SFg7O8yMeg==', N'926a3e8a-4f1f-4db3-89f4-0101fc287455', NULL, 0, 0, NULL, 1, 0, N'admin@mbsvidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd043623-338d-401f-8d20-6420aa61d7ed', N'guest@mbsvidly.com', 0, N'AHTpDnl6qaseHNCxVNyNFLqOyTXmYrLUIO6GjYzjShq4VdgeEm4TOMrKyukrW/lraA==', N'0966ba73-7351-438b-b952-5c92c5403d5d', NULL, 0, 0, NULL, 1, 0, N'guest@mbsvidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ab0f5a21-9fcb-4bfa-89e3-93a11cbffd42', N'CanManageMovies')


            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9a69b4f7-844f-4f24-95b8-a54b22388bcd', N'ab0f5a21-9fcb-4bfa-89e3-93a11cbffd42')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
