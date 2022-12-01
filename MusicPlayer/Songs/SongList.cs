using System.Xml.Linq;

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

        List<SongCollection> songCollection = new List<SongCollection>()
        {
                new SongCollection() { Artist = "israel", SongName="my compliments"}
        };

        public void AddToMusicList()
        {
            songCollection.Add(new SongCollection() { Artist = "meq", SongName = "for reals" });            
        }

        public void DisplayMusicList()
        {
            Console.WriteLine("- \tArtist -- \tSong Title");
            Console.WriteLine("**********************************************************");
            foreach(var song in songCollection)
            {
                Console.WriteLine($"- \t{song.Artist} -- \t{song.SongName}");
            }


        }

        
    }


}
