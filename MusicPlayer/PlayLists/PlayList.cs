using MusicPlayer.Designs.Utility;
using MusicPlayer.Songs;

namespace MusicPlayer.PlayLists
{
    public class PlayList
    {        
        private string? name;
        
        public string? Name { get { return name; } set { name = value; } }

        public void GetData()
        {
            Console.WriteLine("gvh"+Name);
        }

    }

    public class Song
    {
        private string? name;

        public string? Name { get { return name; } set { name = value; } }
    }

    class CreatePlayList
    {
        List<PlayList> playlist = new List<PlayList>();
        List<Song> songAdded = new List<Song>();

        public void PlayList()
        {
            Utility.PlaylistPrompt();

            playlist.Add(new PlayList() { Name = "Default Playlist" });
            playlist.Add(new PlayList() { Name = "Com' on" });
            playlist.Add(new PlayList() { Name = "21 Savage" });
            playlist.Add(new PlayList() { Name = "Jump street" });
            playlist.Add(new PlayList() { Name = "Default Playlist" });
            playlist.Add(new PlayList() { Name = "Obinna" });

            try
            {
                Start: string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Creating a playlist");
                        PlaylistCreation();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Welcome... Here are your playlists");
                        foreach(var lists in playlist)
                        {
                            Console.WriteLine($"\n\t{lists.Name}");
                        }
                        Console.WriteLine("");
                        CreatePlayList create = new();
                        create.PlayList();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Exiting Playlist");
                        Utility.Action();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Do you mind inserting a valid option");
                        goto Start;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void PlaylistCreation()
        {            

            Console.WriteLine("\nAdd new playlist");
            Console.Write("playlist name ====>");

            PlayList lists = new();
            lists.Name = Console.ReadLine();

            playlist.Add(new PlayList() { Name = lists.Name });
            Console.WriteLine("Playlist added successfully\n");

            Utility.LongLine();
            Console.WriteLine("Playlist");
            Utility.LongLine();           

            Start: Console.WriteLine("Press 0 return to main menu");
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    CreatePlayList createNew = new();
                    createNew.PlayList();
                    Console.Clear();                    
                    goto Start;
                default:
                    Console.WriteLine("invalid input");
                    goto Start;
            }                                                                          

        }

        public void AddSongs()
        {
            songAdded.Add(new Song() { Name = "Boom sounds" });

            while (true)
            {                
                Console.WriteLine("\nWhich playlist will you like to add songs to");

                string playlistSearch = Console.ReadLine();

                foreach (var i in playlist)
                {
                    if (i.Name.Equals(playlistSearch))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Utility.LongLine();
                        Console.ResetColor();

                        Console.WriteLine($"\n\tYou are in {i.Name} playlists");
                        Console.WriteLine($"Add song to {i.Name} playlist");
                        Console.Write("=>");

                        string song = Console.ReadLine();

                        songAdded.Add(new Song() { Name = song });

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You have successfully added a song to {i.Name} playlist\n");
                        Console.ResetColor();

                        Utility.LongLine();
                        Console.WriteLine($"Songs in {i.Name} playlist");
                        Console.WriteLine($"\t{songAdded}");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("invalid inputs");                        
                        //break;
                    }
                }
            }
            

        }
    }
}