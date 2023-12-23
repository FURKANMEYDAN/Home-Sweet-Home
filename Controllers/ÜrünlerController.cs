using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using _2.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _2.Controllers
{

    public class ÜrünlerController : Controller
    {

        private readonly DatabaseContext _context;
        private readonly List<Eşyalar> _Eşyalar;
        public ÜrünlerController(DatabaseContext context)
        {
            _context = context;

        }
        public void addImagesFromCSV(Eşyalar model)
        {
           string csvFilePath = "1.csv"; 

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            while (csv.Read())
            {
                string imagePath = csv.GetField<string>(0); 

                var newImage = new Eşyalar
                {
                    Image = imagePath 
                    
                };

                  _context.Add(newImage);
            }

            _context.SaveChangesAsync();
        }
        }
    }


}
