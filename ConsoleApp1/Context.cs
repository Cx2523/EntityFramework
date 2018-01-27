using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComicBook>().Property(cb => cb.Price).HasPrecision(5, 2);
        }

        public DbSet<ComicBook> ComicBooks { get; set; }
        public DbSet<Series> Series { get; set; }
    }
}
