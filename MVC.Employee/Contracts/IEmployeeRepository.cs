using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Employee.Models;
namespace MVC.Employee.Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Models.Employee> GetAll();
        Models.Employee GetEmployee(Guid id);
        void CreateEmployee(Models.Employee employee);
    }
}
