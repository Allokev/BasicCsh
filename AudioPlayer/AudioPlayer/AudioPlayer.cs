﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class AudioPlayer
    {

       public void VolumePlus()
        {
           Volume =  Volume+1;
        }
       public void VolumeMinus()
        {
            Volume = Volume - 1;
        }
       private int _volume;
       public int Volume
        {
            
            get { return _volume; }
            set
            {
                if (value < 0) _volume = 0;
                else if (value > 100) _volume = 100;
                else _volume = value;
            }
        }
        public void Add(string ArtirstSOng)
        {

        }
        public void Add(int AlbumPlaylist)
        {

        }
        public bool Play()
        {
            return true;
        }
        public bool Stop()
        {
            return true;
        }
       public Song[] songs;
    }
}
