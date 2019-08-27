using Microsoft.EntityFrameworkCore.Migrations;

namespace Day_31___EFCoreCodeFirst.Migrations
{
    public partial class PopulatingDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { -1, 0.29999999999999999, "East Wing", "Accounting", "Finance" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { -2, 5000000.0, "West Wing", "Marketing", "Advertising" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { -3, 16.0, "Sales Floor", "Sales", "Peons" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -1, 3, "Marty@McFly.co", "Marty", "McFly" },
                    { -2, 1, "Tannen@McFly.co", "Biff", "Tannen" },
                    { -3, 3, "George@McFly.co", "George", "McFly" },
                    { -4, 2, "Jennifer@McFly.co", "Jennifer", "Parker" },
                    { -5, 1, "Emmett@Brown.co", "Emmett", "Brown" },
                    { -6, 2, "Clara@Brown.co", "Clara", "Clayton" }
                });
        }
    }
}
