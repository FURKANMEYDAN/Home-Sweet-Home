using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2.Models
{
    public class DatabaseContext:DbContext
    {
          public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){

        }
           protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("DataSource=eşyalar.db");
        public DbSet<Eşyalar> Eşyalars => Set<Eşyalar>();
  }
}