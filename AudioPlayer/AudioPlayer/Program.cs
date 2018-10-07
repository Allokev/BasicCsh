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

           
            
            Console.WriteLine(player.Volume);
            Console.ReadLine();

        }
    }
}
