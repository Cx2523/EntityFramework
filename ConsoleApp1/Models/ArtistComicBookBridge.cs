using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ArtistComicBookBridge
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int ComicBookId { get; set; }
        public Artist Artist { get; set; }
        public ComicBook ComicBook { get; set; }
        public Role Role { get; set; }
    }
}
