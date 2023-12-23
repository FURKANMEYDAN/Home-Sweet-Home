using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public  class AnaSayfa
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string[]? Tags { get; set; }
        
        
    }
}