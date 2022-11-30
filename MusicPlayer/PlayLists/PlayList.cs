using MusicPlayer.Designs.Utility;

namespace MusicPlayer.PlayLists
{
    class PlayList
    {
        private int id;
        private string name;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
    }

    class CreatePlayList
    {
        public void PlayList()
        {
            Utility.LongLine();
            Console.WriteLine("\nSorry, you have an empty playlist.\nTo create a playlist ====> Type 1\n" +
                "To cancel ====> Type 0");

            /*while (true)
            {*/
                //int choice = Convert.ToInt32(Console.ReadLine());
                
                try
                {
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Creating a playlist");
                            PlaylistCreation();
                            break;
                        case "0":
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


            //}

        }

        public static void PlaylistCreation()
        {
            List<PlayList> playlist = new List<PlayList>()
            {
                new PlayList(),
                new PlayList() { ID = 1, Name = "israel" }
            };

            playlist.Add(new PlayList() { ID = 2, Name = "Glory" });
            playlist.Add(new PlayList() { ID = 3, Name = "Obinna" });

            

            /*while (string.IsNullOrWhiteSpace(lists.Name))
            {

            }*/
            while (true)
            {
                Console.WriteLine("\nAdd new playlist");
                Console.Write("playlist name ====>");

                PlayList lists = new();
                lists.Name = Console.ReadLine();

                Console.Write("playlist ID ====>");
                lists.ID = Convert.ToInt32(Console.ReadLine());

                playlist.Add(new PlayList() { ID = lists.ID, Name = lists.Name });
                Console.WriteLine("Playlist added successfully\n");
                
                Utility.LongLine();
                Console.WriteLine("Playlist");
                Utility.LongLine();

                foreach (var list in playlist)
                {
                    Console.WriteLine($"-{list.ID} --- {list.Name} ");
                }


                Console.WriteLine("Press 1 to add a new playlist\nPress 2 to return to the main menu");
            }

            


        }
    }
}
