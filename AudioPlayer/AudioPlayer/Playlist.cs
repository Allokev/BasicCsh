using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class Playlist
    {
      public string Name;
      public Song[] songs;

        public Playlist(int number, string name, double duration)
        {
            Console.WriteLine("Номер в плейлисте {0}, имя - {1}, продолжительность - {2} минуты", number, name, duration );
        }
    }
}
