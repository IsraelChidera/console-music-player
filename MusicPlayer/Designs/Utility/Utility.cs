using MusicPlayer.PlayLists;
using MusicPlayer.Songs;

namespace MusicPlayer.Designs.Utility
{
    internal static class Utility
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Boom Music Player\nWhere music lives....\n*******************************\n" +
                "Hello there . . . Good day!");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void LongLine()
        {
            Console.WriteLine("\n**************************************************************************\n");
        }

        public static void Action()
        {
            Console.WriteLine("What do you want to do?\nType 1" +
                " =====> to view playlist\nType 2 =====> to listen to songs\nType 0 =====> to exit application");



            CreatePlayList createPlayList = new CreatePlayList();
            SongList songList = new SongList();
            //string choice = Console.ReadLine();
            //int choice = Convert.ToInt32(Console.ReadLine());
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Ouch!... We hope to see you again");
                    break;
                case "1":
                    Console.WriteLine("Playlist is opening");                    
                    createPlayList.PlayList();
                    break;
                case "2":
                    Console.WriteLine("Opening songs");
                    Songs.Songs.Song();
                    SongList.DisplayMusicList();
                    break;
                default:
                    Console.WriteLine("Invalid input. Do you mind typing a valid option");
                    Console.WriteLine("Utility error");
                    break;
            }

        }

        
    }
}
