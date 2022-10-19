using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class UpdateCategoryColumnConfigure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 40, 55, 342, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 40, 55, 343, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 40, 55, 343, DateTimeKind.Local).AddTicks(2690));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 38, 9, 397, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 38, 9, 398, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 19, 16, 38, 9, 398, DateTimeKind.Local).AddTicks(4905));
        }
    }
}
