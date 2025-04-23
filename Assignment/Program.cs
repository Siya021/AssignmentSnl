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
                        RealWorldObject realWorldObject = new RealWorldObject();

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
