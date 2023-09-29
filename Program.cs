namespace HW1_CodeRefresh
{
    // Ronda Rutherford
    // Code Refresher - Part 1
    // September 29, 2023
    internal class Program
    {
        static public List<Player> Players = new List<Player>();
        static bool isRunning = true;
        static void Main(string[] args)
        {
            PrePopulatePlayersList();
            // Displays Main Menu on run and option to exit after selection is completed
            // Repeats until user enters a selection not on the menu
            while (isRunning)
            {
                DisplayMainMenu();
                DisplayExitOption();
            }

        } // Main
        public static void AddPlayerToPlayersList(string name, int number)
        {
            Players.Add(new Player(name, number));
        } // AddPlayerToPlayersList(string name, int number)
        public static void PrePopulatePlayersList()
        {
            // Prepopulates Players list with 5 players
            Players.Add(new Player("Kiera", 3));
            Players.Add(new Player("Kelvin", 0));
            Players.Add(new Player("Xiomara", 11));
            Players.Add(new Player("Shohei", 22));
            Players.Add(new Player("Kiki", 6));
        } // PrePopulatePlayersList()

        public static void DisplayMainMenu()
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1 - Display all players");
            Console.WriteLine("2 - Display players with odd numbers");
            Console.WriteLine("3 - Display players with names that start with a certain letter");
            Console.WriteLine("4 - Add player");
            Console.WriteLine("Press any other key to exit.");
            UserMainMenuSelection();
        } // DisplayMenu()

        public static void UserMainMenuSelection()
        {
            string userMenuSelection = Console.ReadLine();
            switch (userMenuSelection)
            {
                case "1":
                    DisplayAllPlayerNames();
                    break;
                case "2":
                    DisplayPlayersWithOddNumbers();
                    break;
                case "3":
                    UserDisplayPlayerNamesByFirstLetter();
                    break;
                case "4":
                    UserAddPlayerToPlayersList();
                    break;
                default:
                    isRunning = false;
                    break;
            }

        }
        public static void DisplayAllPlayerNames()
        {
            Console.WriteLine("ALL PLAYERS");
            foreach (Player player in Players)
            {
                Console.WriteLine(player.ToString());
            }
        } // DisplayAllPlayerNames()

        public static void DisplayPlayersWithOddNumbers()
        {
            Console.WriteLine("PLAYERS WITH ODD NUMBERS");
            foreach (Player player in Players)
            {
                if (player.Number % 2 != 0)
                {
                    Console.WriteLine(player.ToString());
                }
            }
        } // DisplayPlayersWithOddNumbers()

        public static void UserDisplayPlayerNamesByFirstLetter()
        {
            DisplayPlayerNamesByFirstLetter(PromptUserForLetter());
        } // UserDisplayPlayerNamesByFirstLetter()
        public static char PromptUserForLetter()
        {
            Console.Write("Please enter an uppercase letter: ");
            string userLetter = Console.ReadLine();
            char.TryParse(userLetter, out char userLetterParsed);
            return userLetterParsed;
        } // PromptUserForLetter()
        public static void DisplayPlayerNamesByFirstLetter(char userLetter)
        {
            Console.WriteLine($"PLAYERS WITH NAMES THAT START WITH {userLetter}");
            foreach (Player player in Players)
            {
                if (player.Name[0] == userLetter)
                {
                    Console.WriteLine(player.ToString());
                }
            }
        } // DisplayPlayerNamesByFirstLetter(char userLetter)

        public static void UserAddPlayerToPlayersList()
        {
            Console.WriteLine("ADD PLAYER");
            Console.Write("Enter Player's Name: ");
            string userPlayerName = Console.ReadLine();
            Console.Write("Enter Player's Number: ");
            string userPlayerNumber = Console.ReadLine();
            int.TryParse(userPlayerNumber, out int userPlayerNumberParsed);
            AddPlayerToPlayersList(userPlayerName, userPlayerNumberParsed);

        } // UserAddPlayerToPlayersList()

        public static void DisplayExitOption()
        {
            Console.WriteLine("Press x to exit or any other key to return to the main menu");
            string userEntry = Console.ReadLine();
            if (userEntry == "x")
            {
                isRunning = false;
            }

        }
    } // class Program
} // namespace