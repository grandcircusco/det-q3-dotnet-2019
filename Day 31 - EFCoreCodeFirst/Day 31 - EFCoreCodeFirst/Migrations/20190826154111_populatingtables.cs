using Microsoft.EntityFrameworkCore.Migrations;

namespace Day_31___EFCoreCodeFirst.Migrations
{
    public partial class populatingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 1, 0.29999999999999999, "East Wing", "Accounting", "Finance" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 2, 5000000.0, "West Wing", "Marketing", "Advertising" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 3, 16.0, "Sales Floor", "Sales", "Peons" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);
        }
    }
}
