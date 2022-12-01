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


            Console.WriteLine("All songs\n- \tArtist -- \tSong Title");

            foreach (var song in songCollection)
            {
                Console.WriteLine($"- \t{song.Artist} -- \t{song.SongName}");
            }


        }


    }


}
