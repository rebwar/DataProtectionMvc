using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Employee.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Rebwar",
                    Family = "poori",
                    AccountNumber = "123-4754-4145",
                    Age = 36
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Ali",
                    Family = "Alizade",
                    AccountNumber = "123-4554-5323",
                    Age = 35
                }
                );
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
