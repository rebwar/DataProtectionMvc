using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using MVC.Employee.Contracts;

namespace MVC.Employee.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository repository;
        private readonly IDataProtector dataProtection;

        public EmployeesController(IEmployeeRepository repository, IDataProtectionProvider dataProtection)
        {
            this.repository = repository;
            this.dataProtection = dataProtection.CreateProtector("MVC.Employee.EmployeesController");
        }
        public IActionResult Index()
        {
            var employees = repository.GetAll();
            foreach (var item in employees)
            {
                var stringid = item.Id.ToString();
                item.EncryptedId = dataProtection.Protect(stringid);
            }
            return View(employees);
        }
        public IActionResult Details(string id)
        {
            var guid_id = Guid.Parse(dataProtection.Unprotect(id));
            var employee=repository.GetEmployee(guid_id);
            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}