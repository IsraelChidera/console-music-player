using MusicPlayer.Designs.Utility;

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

    class CreatePlayList
    {
        public void PlayList()
        {
            Utility.PlaylistPrompt();

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
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Exiting Playlist");
                        Utility.Action();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Do you mind inserting a valid option");
                        Console.WriteLine("\nSorry, you have an empty playlist.\nTo create a playlist ====> Type 1\n" +
                        "To cancel ====> Type 0");
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
            List<PlayList> playlist = new List<PlayList>();
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
                    Console.WriteLine("\n\tPress 1 to add a new playlist\n\tPress 2 to add songs to playlist\n\tPress 0 to return to the main menu");
                    optionToContinue = Console.ReadLine();
                }

                


            }




        }
    }
}
