using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _2.Controllers
{
    
    public class SatinAlController : Controller
    {
   

        public IActionResult Index()
        {
            return View();
        }

   
    }
}