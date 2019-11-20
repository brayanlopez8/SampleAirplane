using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VuelosApp.Pages
{
    public class AvionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}