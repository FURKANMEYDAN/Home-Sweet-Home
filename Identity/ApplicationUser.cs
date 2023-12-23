using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace _2.Identity
{
  
    public class ApplicationUser : IdentityUser
    {
  
        public ApplicationUser()
        {
            
        }
         public ApplicationUser(string name,string surname)
        {
            
        }
       public string? Name {get;set;}
       public string? Surname {get;set;}
        
    }
}