using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2.Models;

namespace _2.Controllers;

public class HomeController: Controller
{

    public IActionResult Index(){
        
        return View(Repository.AnaSayfas);
    }
      

}
