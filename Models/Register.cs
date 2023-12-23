using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Models
{
    public class Register
    {   [Required]
        [DisplayName("Adiniz")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Soyadiniz")]
        public string? Surname { get; set; }
        [Required]
        [DisplayName("KullaniciAdi")]
        public string KullanıcıAdı { get; set; }= string.Empty;
        [Required]
        [DisplayName("Eposta")]
         [EmailAddress(ErrorMessage ="Eposta adresinizi düzgün giriniz!")]
        public string Email { get; set; }= string.Empty;
        [Required]
        [DisplayName("Şifreniz")]
       
        public string Password { get; set; }= string.Empty;
        [Required]
        [DisplayName("Şifre tekrar")]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor!")]
        public string RePassword { get; set; }= string.Empty;
    }
}