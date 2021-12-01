using System;

namespace HelloWorld
{
    class Calculator
    {
        static void Main()
        {
            string choice = WelcomeMessage();
            if (choice == "1")
            {
                NumOperation();
                OfferRepeat(1);
            } else
            {
                DateOperation();
                OfferRepeat(2);
            }

        }



        static string WelcomeMessage()
        {
            Console.WriteLine("=== Welcome to Calculator Land ===");
            Console.WriteLine("Which calculator would you like to use?");
            Console.WriteLine("1. Numbers");
            string calcChoice = GetInput("2. Dates \n");
            
            return calcChoice;
        }


        static void DateOperation()
        {
            string dateInput = GetInput("Please enter a date");
            DateTime date = DateTime.Parse(dateInput);
            int toAdd = int.Parse(GetInput("Enter the number of days you wish to add: "));
            Console.WriteLine($"Your answer is {date.AddDays(toAdd)}");

        }

        static void NumOperation()
        {
            string operation = GetInput("Choose an operation : + - * /");

            int numOfOperations = AskForNum("How many times would you like to perform this operation?");
            int[] nums = new int[numOfOperations];
            

            for (int i = 0; i < numOfOperations; i++)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());

            }
            double answer = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (operation == "+")
                {
                    answer += nums[i];
                }
                if (operation == "-")
                {
                    answer -= nums[i];
                }
                if (operation == "/")
                {
                    answer /= nums[i];
                }
                if (operation == "*")
                {
                    answer *= nums[i];
                }
            }
            string finalAnswer = string.Format("The answer your looking for is {0}", answer);
            Console.WriteLine(finalAnswer);
        }
        static int AskForNum(string message)
        {
            int count;

            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }
        static string GetInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
        static void OfferRepeat(int option)
        {
            string answer = GetInput("Would you like to do another operation? Y/N: ");
            if (answer == "Y" || answer == "y")
            {
                if (option == 1)
                {
                    Calculator.NumOperation();
                    Calculator.OfferRepeat(1);
                }
                else
                {
                    Calculator.DateOperation();
                    Calculator.OfferRepeat(2);
                }
    
            }
            else
            {
                Console.WriteLine("Thank you for using the calculator.");
            }

        }
    }
    
}

