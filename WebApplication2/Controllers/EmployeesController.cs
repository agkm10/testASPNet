using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee[] employees = new Employee[] 
        { 
            new Employee { Id = 1, Name = "Bob", Position = "HR", Salary = 10 }, 
            new Employee { Id = 2, Name = "Tom", Position = "Ops", Salary = 15 }, 
            new Employee { Id = 3, Name = "John", Position = "Acct", Salary = 18 } 
        };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var employee = employees.FirstOrDefault((p) => p.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
