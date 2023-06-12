using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "de83dee7-338b-4558-baab-b53f284e1174", "5f45ccdf-c9cd-4422-94ec-7dcd6f665289", "User", "USER" },
                    { "de83dff9-333b-4598-b87b-b53f284e1174", "22e181a5-94f3-43ef-8b1d-ed571dd97d56", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cc99dee8-333b-4598-b44b-b513284e1174", 0, "3fd42194-e20b-4a0d-b930-f4391978aed8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEF0pdHyBllhPxoRuTttm52bTa/xT6fhOyFSwiHxBdBPuh7t4vacIw6tOYm7/DE0bmQ==", null, false, "0b1509d1-ebed-4fab-a82b-255fc6ec98aa", "", false, "user@localhost.com" },
                    { "dd77dee8-333b-4598-b44b-b513284e1174", 0, "ea0de784-8a27-4c11-8824-1fe65156f16b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM","ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMV1Wt7dY58ASuHDzsORbS61NN3ul310nxtECdhRVCJi1WjWCeZTL/WJANs6Zn9xEA==", null, false, "5f8382fa-69dc-411f-9545-e2bf5605dd7b", "", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "de83dee7-338b-4558-baab-b53f284e1174", "cc99dee8-333b-4598-b44b-b513284e1174" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "de83dff9-333b-4598-b87b-b53f284e1174", "dd77dee8-333b-4598-b44b-b513284e1174" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de83dee7-338b-4558-baab-b53f284e1174", "cc99dee8-333b-4598-b44b-b513284e1174" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de83dff9-333b-4598-b87b-b53f284e1174", "dd77dee8-333b-4598-b44b-b513284e1174" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174");
        }
    }
}
