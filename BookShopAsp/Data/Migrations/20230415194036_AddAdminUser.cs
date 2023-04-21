using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopAsp.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create the admin role
            migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, [Name], NormalizedName) VALUES ('1', 'Admin', 'Admin')");

            // Create the admin user
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = "1",
                UserName = "admin@example.com",
                NormalizedUserName = "admin@example.com",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssw0rd")
            };
            migrationBuilder.InsertData(table: "AspNetUsers",
                                         columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                                         values: new object[] { adminUser.Id, adminUser.UserName, adminUser.NormalizedUserName, adminUser.Email, adminUser.NormalizedEmail, adminUser.EmailConfirmed, adminUser.PasswordHash, adminUser.SecurityStamp });

            // Add the admin user to the admin role
            migrationBuilder.Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('1', '1')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
