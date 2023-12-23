using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
namespace _2.Models
{
    public class Eşyalar
    {
        [Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        
        public string? Image { get; set; }
        public string? Price { get; set; }
    }
}