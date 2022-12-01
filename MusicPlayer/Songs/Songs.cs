using MusicPlayer.Designs.Utility;
using MusicPlayer.PlayLists;

namespace MusicPlayer.Songs
{
    internal static class Songs
    {
        public static void Song()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Utility.LongLine();
            Console.WriteLine("SONGS");
            Utility.LongLine();
            Console.ResetColor();
        }
    }

    class SongsPlayList
    {

        public void Display()
        {
            PlayList playList = new PlayList();

            Console.WriteLine("refactoring ...");
            Console.WriteLine("ff");
            playList.GetData();
            List<PlayList> playlist = new List<PlayList>();
            foreach (var i in playlist)
            {
                Console.WriteLine("Ds");
                
            }
        }
    }
}
