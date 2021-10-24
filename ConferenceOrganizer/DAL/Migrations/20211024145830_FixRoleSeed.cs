using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class FixRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "49aa847f-9cbc-4c6f-97d7-bad674ad6580");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520c5ce2-67b4-4ab7-a4c1-903fa73bd86b", "AQAAAAEAACcQAAAAELjA9ZACBn63XuYb9ZcvJSyF9zNcdCVhkP+Ut4SeyF8zWDjqjfRLogtm83gMayQykA==", "b0dcc58f-bf59-4308-b84e-f46a7df30329" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a4600153-c103-4acc-b27a-80cc4d9f3043");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e27e107d-cfe8-4741-a6f8-7f854570caf7", "AQAAAAEAACcQAAAAEEqS6wM+1RiBenqhPrSohLAzj1v5xKAqO4Fc1ljcgAYWE58i92+c46mhaUnQNaiJNQ==", "3ef609c4-4a79-473b-835c-957f55275877" });
        }
    }
}
