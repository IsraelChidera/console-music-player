using MusicPlayer.Designs.Utility;
using MusicPlayer.PlayLists;

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

        public void DisplayMusicList()
        {
            List<SongCollection> songCollection = new List<SongCollection>()
            {
                new SongCollection() { SongName="my compliments"}
            };
            songCollection.Add(new SongCollection() { SongName = "for reals" });
            songCollection.Add(new SongCollection() { SongName = "Amazed" });
            songCollection.Add(new SongCollection() {  SongName = "Friends" });
            songCollection.Add(new SongCollection() {  SongName = "Grand dad's love" });
            songCollection.Add(new SongCollection() {  SongName = "Go get 'em" });
            //songCollection.Sort();

            Console.WriteLine("All songs\n- \t -- \tSong Title");

            var results = songCollection
                      .OrderByDescending(y => y.SongName);


            foreach (var song in songCollection)
            {
                Console.WriteLine($"- \t -- \t{song.SongName}");
            }

            while (true)
            {
                Utility.LongLine();
                Console.WriteLine("\tTo play all songs, press 1\n\tTo play previous song, press 2\n\tTo next song" +
                    " press 3\n\tTo shuffle song, press 4\n\tTo add song, press 5\n\tTo exit, press 0\n");
                
                Console.Write("====>");
                string musicOption = Console.ReadLine();                

                try
                {
                    switch (musicOption)
                    {
                        case "1":
                            Console.WriteLine("Playing all songs");
                            foreach (var song in songCollection)
                            {
                                Console.WriteLine($"Now playing\n- \t-- \t{song.SongName}");
                                Thread.Sleep(2000);
                            }
                            break;                        
                        case "2":
                            Console.WriteLine("Play previous song");
                            Console.WriteLine(songCollection);
                            int index = 1;
                            //int prev = songCollection.First<[index - 1]>;
                            break;
                        case "3":
                            Console.WriteLine("Play next song");
                            break;
                        case "4":
                            Console.WriteLine("Shuffle");
                            break;
                        case "5":
                            Console.WriteLine("Adding songs");
                            Console.WriteLine("\nAdd new song");
                            Console.Write("song ====>");
                            SongCollection songsList = new();
                            songsList.SongName = Console.ReadLine();
                            songCollection.Add(new SongCollection() { SongName = songsList.SongName });
                            Console.WriteLine("You've added a song...\n");
                            break;
                        default:
                            Console.WriteLine("Please provide a valid input");
                            break;
                    }
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid input");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


        }


    }


}
