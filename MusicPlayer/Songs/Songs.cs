using MusicPlayer.Designs.Utility;

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
}
