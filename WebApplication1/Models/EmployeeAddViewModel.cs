using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models
{
    public class EmployeeAddViewModel
    {
        public Employee employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}