﻿// <auto-generated />
using Day_31___EFCoreCodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Day_31___EFCoreCodeFirst.Migrations
{
    [DbContext(typeof(CompanyCFDbContext))]
    [Migration("20190826154111_populatingtables")]
    partial class populatingtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day_31___EFCoreCodeFirst.Context.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Budget = 0.29999999999999999,
                            Location = "East Wing",
                            Name = "Accounting",
                            Type = "Finance"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Budget = 5000000.0,
                            Location = "West Wing",
                            Name = "Marketing",
                            Type = "Advertising"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Budget = 16.0,
                            Location = "Sales Floor",
                            Name = "Sales",
                            Type = "Peons"
                        });
                });

            modelBuilder.Entity("Day_31___EFCoreCodeFirst.Context.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DepartmentId = 3,
                            Email = "Marty@McFly.co",
                            FirstName = "Marty",
                            LastName = "McFly"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DepartmentId = 1,
                            Email = "Tannen@McFly.co",
                            FirstName = "Biff",
                            LastName = "Tannen"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DepartmentId = 3,
                            Email = "George@McFly.co",
                            FirstName = "George",
                            LastName = "McFly"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DepartmentId = 2,
                            Email = "Jennifer@McFly.co",
                            FirstName = "Jennifer",
                            LastName = "Parker"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DepartmentId = 1,
                            Email = "Emmett@Brown.co",
                            FirstName = "Emmett",
                            LastName = "Brown"
                        },
                        new
                        {
                            EmployeeId = 6,
                            DepartmentId = 2,
                            Email = "Clara@Brown.co",
                            FirstName = "Clara",
                            LastName = "Clayton"
                        });
                });

            modelBuilder.Entity("Day_31___EFCoreCodeFirst.Context.Employee", b =>
                {
                    b.HasOne("Day_31___EFCoreCodeFirst.Context.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
