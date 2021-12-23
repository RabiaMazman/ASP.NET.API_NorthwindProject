using Microsoft.EntityFrameworkCore;
using NorthwindProject.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entity
{
    public class Nortwind_DbContext : DbContext
    {
        public Nortwind_DbContext(DbContextOptions<Nortwind_DbContext> dbContextOptions)
           : base(dbContextOptions)
        {

        }

        public Nortwind_DbContext() { }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Products> products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Scans a given assembly for all types that implement IEntityTypeConfiguration, and registers each one automatically
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
