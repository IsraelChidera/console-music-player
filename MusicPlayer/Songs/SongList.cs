using MusicPlayer.Designs.Utility;

namespace MusicPlayer.Songs
{
    class SongCollection
    {
        private string? songName;
        public string? SongName { get { return songName; } set { songName = value; } }
    }

    public class SongList
    {
        //List<SongCollection> songCollection = List<SongCollection>(){};



        public void ShuffleList()
        {
            var random = new Random();
        }

        public static void DisplayMusicList()
        {
            List<SongCollection> songCollection = new List<SongCollection>()
                    {
                        new SongCollection() { SongName="my compliments"}
                    };
            songCollection.Add(new SongCollection() { SongName = "for reals" });
            songCollection.Add(new SongCollection() { SongName = "Amazed" });
            songCollection.Add(new SongCollection() { SongName = "Friends" });
            songCollection.Add(new SongCollection() { SongName = "Grand dad's love" });
            songCollection.Add(new SongCollection() { SongName = "Go get 'em" });
            //songCollection.Sort();


            var results = songCollection
                      .OrderByDescending(y => y.SongName);

            Console.WriteLine("All songs");
            foreach (var song in songCollection)
            {
                Console.WriteLine($"- \t -- \t{song.SongName}");
            }

            Utility.LongLine();

            bool isTrue = true;
            while (isTrue)
            {
                try
                {

                    Start: Console.WriteLine("\nMusic section\nWhat do you want to do?");
                    Console.WriteLine("\tTo play all songs, press 1\n\tTo add song, press 2\n\tTo exit, press 0\n");
                    Console.Write("====>");
                    string musicOption = Console.ReadLine();
                    SongCollection songsList = new();

                    switch (musicOption)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Playing all songs");
                            foreach (var song in songCollection)
                            {
                                Console.WriteLine($"Now playing\n- \t-- \t{song.SongName}");
                                Thread.Sleep(2000);
                            }
                            goto Start;                                                                        
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Adding songs");
                            Console.WriteLine("\nAdd new song");
                            Console.Write("song ====>");


                            songsList.SongName = Console.ReadLine();
                            songCollection.Add(new SongCollection() { SongName = songsList.SongName });
                            Console.WriteLine("You've added a song...\n");

                            Console.WriteLine("\nAll songs");
                            foreach (var songs in songCollection)
                            {
                                Console.WriteLine($"\n\t{songs.SongName}");
                            }
                            //isTrue = false;
                                                        
                            goto Start;
                        case "0":
                            Console.Clear();
                            Console.WriteLine("\nExiting song list");
                            Utility.Action();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nPlease provide a valid input\n");
                            Console.ResetColor();
                            DisplayMusicList();
                            goto Start;
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid input");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }




        }


    }


}
