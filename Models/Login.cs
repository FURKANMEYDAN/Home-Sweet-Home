using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class Login 
    {
        [Required]
        [DisplayName("KullanıcıAdı")]
        public string KullanıcıAdı { get; set; } = string.Empty;
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }= string.Empty;
        [DisplayName("Beni Hatırla")]
        public string  rememberMe { get; set; }= string.Empty;
    }
}