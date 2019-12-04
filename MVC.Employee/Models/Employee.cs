using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Employee.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }
        public string Family { get; set; }
        [Required(ErrorMessage ="Age is Required")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Account Number is required")]
        public string AccountNumber { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; }
    }
}
