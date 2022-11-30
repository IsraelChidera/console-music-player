using MusicPlayer.PlayLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Songs
{
    internal class Songs
    {
        public void Song()
        {
            CreatePlayList.PlaylistCreation();
            PlayList p = new();
            Console.WriteLine(p.Name);
        }
    }
}
