using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_31___EFCoreCodeFirst.Context
{
    public class CompanyCFDbContext : DbContext
    {
        public CompanyCFDbContext(DbContextOptions<CompanyCFDbContext> options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 1, Name = "Accounting", Location = "East Wing", Type = "Finance", Budget = 0.30 },
                new Department() { Name = "Marketing", Location = "West Wing", Type = "Advertising", Budget = 5000000, DepartmentId = 2 },
                new Department() { Name = "Sales", Location = "Sales Floor", Type = "Peons", Budget = 16, DepartmentId = 3 }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { FirstName = "Marty", LastName = "McFly", Email = "Marty@McFly.co", DepartmentId = 3, EmployeeId = 1 },
                new Employee() { FirstName = "Biff", LastName = "Tannen", Email = "Tannen@McFly.co", DepartmentId = 1, EmployeeId = 2 },
                new Employee() { FirstName = "George", LastName = "McFly", Email = "George@McFly.co", DepartmentId = 3, EmployeeId = 3 },
                new Employee() { FirstName = "Jennifer", LastName = "Parker", Email = "Jennifer@McFly.co", DepartmentId = 2, EmployeeId = 4 },
                new Employee() { FirstName = "Emmett", LastName = "Brown", Email = "Emmett@Brown.co", DepartmentId = 1, EmployeeId = 5 },
                new Employee() { FirstName = "Clara", LastName = "Clayton", Email = "Clara@Brown.co", DepartmentId = 2, EmployeeId = 6 }
                );
        }
    }
}
