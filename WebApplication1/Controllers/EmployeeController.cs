﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="İzmir", Value="35"},
                    new SelectListItem{Text="Ankara", Value="06"}
                }
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View(employee);
        }

    }
}