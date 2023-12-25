using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class CompositeModel
    {
        public Feedback Feedback { get; set; }
        public List<AnaSayfa> AnaSayfaList { get; set; }
    }
}