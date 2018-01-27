using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Artist
    {
        public Artist()
        {
            ComicBooks = new List<ArtistComicBookBridge>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ArtistComicBookBridge> ComicBooks {get; set;}
    }
}
