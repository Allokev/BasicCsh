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
       public Artist artistOfCurrentSOng;
       public Genre genreOfCurrentSong;
       public int duration;
        public Song(string x3, int x4 = 4, int x5 = 6)
        {
            Console.WriteLine("Вы выбрали песню {0}, под номером {1}, слушали сегондя {2} раз", x3,x4,x5);
        }
        
    }
}
