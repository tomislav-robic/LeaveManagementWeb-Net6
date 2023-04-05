using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "12b441d5-f626-431b-8f0b-c972c612e413");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "b5f05b5b-5e38-4fde-ab88-67f5d83ab3d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8ce8dbd6-14f2-4ba9-b208-d4c4ab99ab2f", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEI0lbYPpoJMMaa77SvC8mSklGg2QZyfok+Z1BM3sXDL4PYrAQEXMhKeRhpTO5emkdQ==", "47d075bb-aaf7-4ab6-9a0a-7b3666bfa746", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d485eb1-e6a8-4612-a668-5879a782d395", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOTORAe48WpLw943XjjkjLZ9gSjFkmbpY06ci9Opm8rmPxDHJPJEtpnz6Mu0gjEa+A==", "ad631028-1d27-45e6-9d06-dda7ad7052b3", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "5f45ccdf-c9cd-4422-94ec-7dcd6f665289");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "22e181a5-94f3-43ef-8b1d-ed571dd97d56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3fd42194-e20b-4a0d-b930-f4391978aed8", false, null, "AQAAAAEAACcQAAAAEF0pdHyBllhPxoRuTttm52bTa/xT6fhOyFSwiHxBdBPuh7t4vacIw6tOYm7/DE0bmQ==", "0b1509d1-ebed-4fab-a82b-255fc6ec98aa", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ea0de784-8a27-4c11-8824-1fe65156f16b", false, null, "AQAAAAEAACcQAAAAEMV1Wt7dY58ASuHDzsORbS61NN3ul310nxtECdhRVCJi1WjWCeZTL/WJANs6Zn9xEA==", "5f8382fa-69dc-411f-9545-e2bf5605dd7b", null });
        }
    }
}
