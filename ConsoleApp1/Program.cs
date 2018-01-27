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

                Series SpiderManSeries = new Series()
                {
                    Title = "The Spider Man Series"
                };

                Series BatManSeries = new Series()
                {
                    Title = "The Bat Man Series"
                };


                context.ComicBooks.Add(new ComicBook()
                {
                    Series = SpiderManSeries,
                    IssueNumber = 1,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                });

                context.ComicBooks.Add(new ComicBook()
                {
                    Series = SpiderManSeries,
                    IssueNumber = 2,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                });

                context.ComicBooks.Add(new ComicBook()
                {
                    Series = BatManSeries,
                    IssueNumber = 1,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                });

                context.SaveChanges();

                var comicBooks = context.ComicBooks.ToList();
                
                foreach(var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.Series.Title);
                }
                Console.WriteLine("Test");
                Console.ReadLine();
            }
        }
    }
}
