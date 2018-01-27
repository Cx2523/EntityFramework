using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<ArtistComicBookBridge>();
        }

        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }

        public Series Series { get; set; }
        public ICollection<ArtistComicBookBridge> Artists { get; set; }

        public void AddArtist(Artist artist, Role role)
        {
            Artists.Add(new ArtistComicBookBridge()
            {
                Artist = artist,
                Role = role
            }); 
        }

    }
}
