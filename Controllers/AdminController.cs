using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2.Models;

namespace _2.Controllers
{

    public class AdminController : Controller
    {
    
        public IActionResult Admin()
        {
            return View();
        }


    }
}