using MusicPlayer.Designs.Utility;

namespace MusicPlayer.Songs
{
    class SongCollection
    {
        private string? artist;
        private string? songName;

        public string? Artist { get { return artist; } set { artist = value; } }
        public string? SongName { get { return songName; } set { songName = value; } }
    }

    public class SongList
    {
        //List<SongCollection> songCollection = List<SongCollection>(){};



        public void AddToMusicList()
        {

        }

        public void DisplayMusicList()
        {
            List<SongCollection> songCollection = new List<SongCollection>()
            {
                new SongCollection() { Artist = "israel", SongName="my compliments"}
            };
            songCollection.Add(new SongCollection() { Artist = "meq", SongName = "for reals" });
            songCollection.Add(new SongCollection() { Artist = "Tut", SongName = "Amazed" });
            songCollection.Add(new SongCollection() { Artist = "Fruyi", SongName = "Friends" });
            songCollection.Add(new SongCollection() { Artist = "Tonali", SongName = "Grand dad's love" });
            songCollection.Add(new SongCollection() { Artist = "Folu", SongName = "Go get 'em" });
            //songCollection.Sort();

            Console.WriteLine("All songs\n- \tArtist -- \tSong Title");

            var results = songCollection
                      .OrderByDescending(y => y.Artist);
                      

            foreach (var song in results)
            {
                Console.WriteLine($"- \t{song.Artist} -- \t{song.SongName}");
            }

            while (true)
            {
                Utility.LongLine();
                Console.WriteLine("\tTo play all songs, press 1\n\tTo play previous song, press 2\n\tTo next song" +
                    " press 3\n\tTo shuffle song, press 4\n\tTo add song, press 5\n\tTo exit, press 0\n");
                
                Console.Write("====>");
                string musicOption = Console.ReadLine();

                Console.WriteLine(musicOption);

                try
                {
                    switch (musicOption)
                    {
                        case "1":
                            Console.WriteLine("Playing all songs");
                            foreach (var song in results)
                            {
                                Console.WriteLine($"Now playing\n- \t-- \t{song.SongName}");
                                Thread.Sleep(2000);
                            }
                            break;                        
                        case "2":
                            Console.WriteLine("Play previous song");
                            break;
                        case "3":
                            Console.WriteLine("Play next song");
                            break;
                        case "4":
                            Console.WriteLine("Shuffle");
                            break;
                        case "5":
                            Console.WriteLine("Adding songs");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Invalid input");
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


        }


    }


}
