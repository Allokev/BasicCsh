using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new AudioPlayer();
            var songsong = new Song();
            var numberOfArtist = new Artist();   
            var SongInPlayList = new Playlist();
            /*player.Volume = 100;
            player.VolumeMinus();
            player.VolumeMinus();
            player.VolumeMinus();

            Console.WriteLine(player.Volume);*/
            //Console.WriteLine(numberOfArtist.x1);
            // player.Play();
            //player.Add(songsong);
            songsong.thisSong();
            Console.ReadLine();

        }
    }
}
