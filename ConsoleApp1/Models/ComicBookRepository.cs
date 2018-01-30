using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class ComicbookRepository
    {
        //CRUD ops
        //Create
        public void CreateComicBook(ComicBook comicbook)
        {
            using (Context context = new Context())
            {
                context.ComicBooks.Add(comicbook);
                context.SaveChanges();
            }
        }

        //Read
        public List<ComicBook> GetComicBooks()
        {
            using (Context context = new Context())
            {
                return context.ComicBooks
                    .ToList();
            }
        }
        //Update
        public void UpdateComicBooks(ComicBook comicBook)
        {
            using (Context context = new Context())
            {
                context.ComicBooks.Attach(comicBook);
                context.Entry(comicBook).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //Delete
        public void DeleteComicBook(int id)
        {
            using (var context = new Context())
            {
                var comicbook = new ComicBook() { Id = id };
                context.Entry(comicbook).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }



    }
}
