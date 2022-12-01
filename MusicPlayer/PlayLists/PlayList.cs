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
            playlist.Add(new PlayList() { Name = "Obinna" });
            playlist.Add(new PlayList() { Name = "21 Savage" });
            playlist.Add(new PlayList() { Name = "Jump street" });


            try
            {
                string choice = Console.ReadLine();

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
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void PlaylistCreation()
        {
            
            //{
              //  new PlayList() { Name = "israel" }
            //};

            playlist.Add(new PlayList() { Name = "Default Playlist" });
            playlist.Add(new PlayList() { Name = "Obinna" });            
            
            while (true)
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

                foreach (var list in playlist)
                {
                    Console.WriteLine($"--- {list.Name} ");
                }

                Utility.LongLine();
                Console.WriteLine("\n\tPress 1 to add a new playlist\n\tPress 2 to add songs to playlist\n\tPress 0 to return to the main menu");
                string optionToContinue = Console.ReadLine();

                if (optionToContinue == "1" && !String.IsNullOrEmpty(optionToContinue))
                {
                    Console.Clear();
                    continue;
                }
                else if(optionToContinue == "2" && !String.IsNullOrEmpty(optionToContinue))
                {
                    Console.Clear();
                    Console.WriteLine("Adding songs to playlist");
                    AddSongs();
                    break;
                }
                else if (optionToContinue == "0" && !String.IsNullOrEmpty(optionToContinue))
                {
                    Console.Clear();
                    Utility.Action();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid inputs");
                   
                }


            }

        }

        public void AddSongs()
        {
            songAdded.Add(new Song() { Name = "Boom sounds" });

            while (true)
            {
                Console.WriteLine("Adding songs to playlist 2");
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
                        break;
                    }

                    else
                    {
                        Console.WriteLine("invalid inputs");
                        continue;
                    }
                }
            }
            

        }
    }
}
