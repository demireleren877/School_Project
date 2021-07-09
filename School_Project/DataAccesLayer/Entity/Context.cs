using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.Entity
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NQ5RMBT; database=SchoolProjects; integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
