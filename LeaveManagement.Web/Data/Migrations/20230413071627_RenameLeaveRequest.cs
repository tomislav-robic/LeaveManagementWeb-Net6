using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class RenameLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "f6af1cb1-f34a-4870-a03b-ea9a4f4bd9cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "dfc126ee-546f-4aa3-95cb-209168e6e0c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b5efd6-acdd-4fcb-aafd-754ef1de236e", "AQAAAAEAACcQAAAAEKRHogWl7Zv/poQ8M/kEostU+uQFKcQYp4tMFKOu31WF19uxTqE0iK6GxsziAkAwBg==", "29ab894a-2dbd-4445-ac65-3353e55bdfa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2863f1d7-8379-4ca5-9363-424c05d89e5f", "AQAAAAEAACcQAAAAEEDM1hmPXlONI6Zhq+jB/feX1U0SDnGvH5mJhbs9jbrFchIHxeD12Q0/xN6gfiFZDw==", "70034499-c7be-4113-8a42-2ffcd4e1a019" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "c9375be6-b93a-4157-b582-6c2f4c69f240");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "98cba7b3-7221-4c94-9164-8f5f29bf2673");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40f5c9e6-dadb-49c1-90db-e76163043a7c", "AQAAAAEAACcQAAAAELDKciaGsYSbs5Ej829GsIfLuPvVnjfoJbB3yv9p49bKYELBQ3qjTWlBB9Tqc8cApQ==", "cd2582fa-d3e2-464b-9d5f-100bb59ab2de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ef0f2cc-e6c7-4919-a750-c7d08c8f777f", "AQAAAAEAACcQAAAAEBgFtSjymqF6HX5g6TuJ86vYsTVXG7+poGU1VR9TRQ1XZyiT7wwkhrvbP/c0kE93UQ==", "e9214921-e58c-435d-9a7a-4839a984c2df" });
        }
    }
}
