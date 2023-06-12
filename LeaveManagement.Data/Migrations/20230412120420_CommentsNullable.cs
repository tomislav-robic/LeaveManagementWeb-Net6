using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class CommentsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
