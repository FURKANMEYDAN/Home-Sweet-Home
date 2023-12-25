using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLitePCL;

namespace _2.Controllers
{

    public class FeedbackController : Controller
    {
        public IActionResult Feedback(){
            if(!User.Identity.IsAuthenticated){
                ViewBag.Message("Lütfen giriş yapınız!");
            }
            return View();
        }
        private readonly DatabaseContext _context;
        public FeedbackController(DatabaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult SubmitFeedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }

    }
}