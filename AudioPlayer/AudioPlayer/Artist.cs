﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class Artist
    {
        public int x1;
        public string x2;
        public string Name;
        public Song[] songs;
        public Artist(int number)
         {
             Console.Write("Вы выбрали артиста под номером:");
             x1 = number;
         }
        public Artist(double number)
        {
            Console.Write("Возможно, вы имели ввиду артиста под номером:");
            x1 = (int)number;
        }
        public Artist(string thatName, int number)
        {
            x1 = number;
            x2 = thatName;
            Console.Write("Вы выбрали артиста " + x2 + " под номером " + x1);
            
        }
    }
}