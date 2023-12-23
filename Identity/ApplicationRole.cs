using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace _2.Identity
{
    public class ApplicationRole:IdentityRole

    {
        public string? Description {get;set;} 
        public ApplicationRole(){

        }
        public ApplicationRole(string roleName,string description){
            this.Description=description;
            
        }          
    }
}