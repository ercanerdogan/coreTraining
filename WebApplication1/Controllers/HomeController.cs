using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "core training";
        }

        public ActionResult listEmployee(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{id=1, firstName="Ercan", lastName="Erdoğan", cityID=1},
                new Employee{id=2, firstName="Fatma", lastName="Erdoğan", cityID=1},
                new Employee{id=3, firstName="Zehra Selvi", lastName="Erdoğan", cityID=1},
            };


            if (string.IsNullOrEmpty(key))
            {
                return Json(employees);
            }
            else
            {
                var result = employees.Where(e => e.firstName.ToLower().Contains(key));
                return Json(result);
            }

        }

        public ViewResult SearchForm()
        {
            return View();
        }

    }
}