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
                        break;
                    case "2":
                        List<FootbalTeam> teams = new List<FootbalTeam>();

                        teams.Add(new FootbalTeam("Liverpool", "Arne Slot", 11, LeagueEnum.PremierLeague, 24, 7, 2));
                        teams.Add(new FootbalTeam("Barcelona", "Coach B", 11, LeagueEnum.LaLiga, 24, 4, 5));
                        teams.Add(new FootbalTeam("Bayern", "Coach C", 11, LeagueEnum.Bundesliga, 22, 6, 2));
                        teams.Add(new FootbalTeam("InterMilan", "Coach D", 11, LeagueEnum.SerieA, 21, 8, 4));
                        teams.Add(new FootbalTeam("PSG", "Coach E", 11, LeagueEnum.Ligue1, 24, 6, 0));

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
    }
}
