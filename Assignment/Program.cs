using System.Runtime.CompilerServices;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Assigment Pack 2");
                Console.WriteLine("1. Number2Words - Assignment 3");
                Console.WriteLine("2. Real World Object - Assignment 4");
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("Please select an option (1 or 2): ");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        NumberToWordsMenu();
                        break;
                    case "2":
                        FootbalTeamMenu();
                        break;
                    case "3":
                        Console.WriteLine("Returning to Main Menu");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
               
            }
        }

        private static void NumberToWordsMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter a number to convert to words:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string words = NumberToWords.ConvertToWords(number);
                Console.WriteLine($"The number in words is: {words}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }

        private static void FootbalTeamMenu()
        {
            List<FootbalTeam> teams = new List<FootbalTeam>

            {
                new FootbalTeam("Liverpool", "Arne Slot", 11, LeagueEnum.PremierLeague, 24, 7, 2),
                new FootbalTeam("Barcelona", "Hansi Flick", 11, LeagueEnum.LaLiga, 24, 4, 5),
                new FootbalTeam("Bayern", "Vincent Company", 11, LeagueEnum.Bundesliga, 22, 6, 2),
                new FootbalTeam("InterMilan", "Simone Inzaghi", 11, LeagueEnum.SerieA, 21, 8, 4),
                new FootbalTeam("PSG", "Luis Enrique", 11, LeagueEnum.Ligue1, 24, 6, 0)
            }
            ;

            foreach (var team in teams)
            {
                team.CalculatePoints();
 
            }

            foreach (var team in teams)
            {
                Console.WriteLine(team.DisplayTeamInfo());
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
