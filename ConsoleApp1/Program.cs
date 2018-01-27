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

                Artist artist1 = new Artist()
                {
                    Name = "Stan Lee"
                };
                Artist artist2 = new Artist()
                {
                    Name = "Bruce Lee"
                };
                Artist artist3 = new Artist()
                {
                    Name = "Chuck Norris"
                };

                Role role1 = new Role()
                {
                    Name = "Pencils"
                };
                Role role2 = new Role()
                {
                    Name = "Colors"
                };

                ComicBook comicbook1 = new ComicBook()
                {
                    Series = SpiderManSeries,
                    IssueNumber = 1,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                };
                ComicBook comicbook2 = new ComicBook()
                {
                    Series = SpiderManSeries,
                    IssueNumber = 2,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                };
                ComicBook comicbook3 = new ComicBook()
                {
                    Series = BatManSeries,
                    IssueNumber = 1,
                    Description = "Really Neato",
                    PublishedOn = DateTime.Today
                };

                comicbook1.AddArtist(artist1, role1);
                comicbook1.AddArtist(artist2, role2);
                comicbook2.AddArtist(artist3, role1);
                comicbook2.AddArtist(artist2, role2);
                comicbook3.AddArtist(artist3, role1);
                comicbook3.AddArtist(artist1, role2);

                context.ComicBooks.Add(comicbook1);
                context.ComicBooks.Add(comicbook2);
                context.ComicBooks.Add(comicbook3);
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
