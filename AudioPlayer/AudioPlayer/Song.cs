using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class Song
    {
        public string Name;
       public string Lyrics { get; set; }
       public Artist artistOfCurrentSOng;
       public Genre genreOfCurrentSong;
       public int duration;
        Genre name = new Genre();
        public void thisSong()
        {
            Lyrics = "Lyrics of song";
            Console.WriteLine(Lyrics);
        }
        
    }
}
