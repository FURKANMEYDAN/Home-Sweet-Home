using System.Globalization;
using _2.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace _2.Controllers
{

    public class DetaylarController : Controller
    {
        public IActionResult Ramona()
        {
            return View();
        }
        public IActionResult Wander()
        {
            return View();
        }
        public IActionResult Bosporus()
        {
            return View();
        }

        public IActionResult OturmaOdasi()
        {
            return View();
        }
        public IActionResult Mutfak()
        {
            return View();
        }
        public IActionResult Banyo()
        {
            return View();
        }
        public IActionResult Eşyalar()
        {
            return View(EşyaRepository.Eşyalars);
        }
        public IActionResult Odalar()
        {

            return View(OdaRepository.Odalars);
        }
        public IActionResult Urunler(int? id)
        {
            if (id == null)
            {
                return Redirect("/home");
            }
            var eşya = EşyaRepository.GetById(id);
            return View(eşya);

        }
        public IActionResult Bakın(Odalar odalar)
        {
            int idfromFirstmodel = odalar.Id;

            Eşyalar eşyalar = new Eşyalar();
            if (odalar.Id == eşyalar.Id)
            {
                return View(eşyalar);
            }

            return View(eşyalar);
        }
        public IActionResult List()
        {
            return View(EşyaRepository.Eşyalars);
        }

    }
}
