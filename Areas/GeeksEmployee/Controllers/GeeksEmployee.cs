using Microsoft.AspNetCore.Mvc;
using MVC5Tutorial.Areas.GeeksEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5Tutorial.Areas.GeeksEmployee.Controllers
{
    [Area("GeeksEmployee")]
    [Route("/GeeksEmployee")]
    public class GeeksEmployee : Controller
    {        
        public IActionResult Index()
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = 1,
                FirstName = "Paul",
                LastName = "Andrew",
                Location = "Mumbai",
                Email = "Paul@geeksarray.com"
            };
            return View(employee);
        }
    }
}
