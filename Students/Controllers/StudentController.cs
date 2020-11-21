using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Students.Models;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentIndex()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }
    }
}
