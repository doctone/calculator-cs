using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            string choice = WelcomeMessage();
            if (choice == "1")
            {
                NumCalculator.NumOperation();
                OfferRepeat(1);
            } else
            {
                DateCalculator.DateOperation();
                OfferRepeat(2);
            }

        }
        public static int AskForNum(string message)
        {
            int count;

            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }

        public static void OfferRepeat(int option)
        {
            string answer = GetInput("Would you like to do another operation? Y/N: ");
            if (answer == "Y" || answer == "y")
            {
                if (option == 1)
                {
                    NumCalculator.NumOperation();
                    OfferRepeat(1);
                }
                else
                {
                    DateCalculator.DateOperation();
                    OfferRepeat(2);
                }

            }
            else
            {
                Console.WriteLine("Thank you for using the calculator.");
            }

        }
        public static string WelcomeMessage()
        {
            Console.WriteLine("=== Welcome to Calculator Land ===");
            Console.WriteLine("Which calculator would you like to use?");
            Console.WriteLine("1. Numbers");
            string calcChoice = GetInput("2. Dates \n");

            return calcChoice;
        }

        public static string GetInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }


        
        
    
}

