using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Message { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty;
    }
}