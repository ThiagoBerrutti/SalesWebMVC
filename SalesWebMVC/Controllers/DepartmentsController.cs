using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SalesWebMVC.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>
            {
                new Department { Id = 1, Name = "Electronics" },
                new Department { Id = 2, Name = "Fashion" },
                new Department { Id = 3, Name = "Tools" }
            };

            return View(list);
        }
    }
}
