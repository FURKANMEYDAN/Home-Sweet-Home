using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _2.Models
{
    public class IdentityContext:IdentityDbContext<AppUser,AppRole,string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("DataSource=mydb.db");
     
    
    
    }
}