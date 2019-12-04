using MVC.Employee.Contracts;
using MVC.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Employee.Repositories
{
    public class Employeerepository : IEmployeeRepository
    {
        private readonly EmployeeContext context;

        public Employeerepository(EmployeeContext context)
        {
            this.context = context;
        }
        public void CreateEmployee(Models.Employee employee)
        {
            context.Add(employee);
            context.SaveChanges();
        }

        public IEnumerable<Models.Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Models.Employee GetEmployee(Guid id)
        {
            return context.Employees.FirstOrDefault(c => c.Id == id);
        }
    }
}
