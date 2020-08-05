using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           /// return "Hello from home controller";
            return View();
        }
    }
}
