using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dee7-338b-4558-baab-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "d5bb34f7-7aff-43b0-a3eb-19b98a625cdc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de83dff9-333b-4598-b87b-b53f284e1174",
                column: "ConcurrencyStamp",
                value: "7bd81f78-62b1-4fe9-97b2-4c5e1af35a32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc99dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c7bed2c-3866-4890-97fe-b0e82640bc65", "AQAAAAEAACcQAAAAENJ+/AVV0F1zOm1XfWOqbC8I7HdTW/KiFRVOM2oTUXDIoQR3Dvj7dn/Kd3WGvKWI4w==", "d54ccac4-1150-498f-ab43-2d99b16eaf81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74b0d586-4999-4b6d-9c82-15897c757c4c", "AQAAAAEAACcQAAAAEL7vB5Qp3Z8aaxM/jmrXR5+uVj5gqtts+9O3ZsVJBxevEw7fFpN62yPBqVSu9b0K6Q==", "2c28956d-060b-4704-a462-ed28ffe38ae3" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce8dbd6-14f2-4ba9-b208-d4c4ab99ab2f", "AQAAAAEAACcQAAAAEI0lbYPpoJMMaa77SvC8mSklGg2QZyfok+Z1BM3sXDL4PYrAQEXMhKeRhpTO5emkdQ==", "47d075bb-aaf7-4ab6-9a0a-7b3666bfa746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd77dee8-333b-4598-b44b-b513284e1174",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d485eb1-e6a8-4612-a668-5879a782d395", "AQAAAAEAACcQAAAAEOTORAe48WpLw943XjjkjLZ9gSjFkmbpY06ci9Opm8rmPxDHJPJEtpnz6Mu0gjEa+A==", "ad631028-1d27-45e6-9d06-dda7ad7052b3" });
        }
    }
}
