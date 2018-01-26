using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook()
                {
                    SeriesTitle = "Spiderman",
                    IssueNumber = 1,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                });

                context.SaveChanges();

                var comicBooks = context.ComicBooks.ToList();
                
                foreach(var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.SeriesTitle);
                }
                Console.WriteLine("Test");
                Console.ReadLine();
            }
        }
    }
}
