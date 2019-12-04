﻿// <auto-generated />
using System;
using MVC.Employee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.Employee.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC.Employee.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber")
                        .IsRequired();

                    b.Property<int>("Age");

                    b.Property<string>("Family");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a8868477-e816-4377-976e-9371df821701"),
                            AccountNumber = "123-4754-4145",
                            Age = 36,
                            Family = "poori",
                            Name = "Rebwar"
                        },
                        new
                        {
                            Id = new Guid("a437bd3a-f9c5-47fc-80e0-cac391786834"),
                            AccountNumber = "123-4554-5323",
                            Age = 35,
                            Family = "Alizade",
                            Name = "Ali"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
