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
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
