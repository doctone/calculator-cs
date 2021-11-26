using System;

namespace HelloWorld
{
    class Calculator
    {
        static void Main()
        {
            WelcomeMessage();
            Operation();
            OfferRepeat();
        }



        static void WelcomeMessage()
        {
            Console.WriteLine("=== Welcome to Calculator Land ===");
        }


        static void Operation()
        {
            string operation = GetInput("Choose an operation : + - * /");

            int numOfOperations = AskForNum("How many times would you like to perform this operation?");
            int[] nums = new int[numOfOperations];
            

            for (int i = 0; i < numOfOperations; i++)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());

            }
            int answer = nums[0];
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
            Console.WriteLine(answer);
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
        static void OfferRepeat()
        {
            string answer = GetInput("Would you like to do another operation? Y/N: ");
            if (answer == "Y")
            {
                Calculator.Operation();
                Calculator.OfferRepeat();
            }
            else
            {
                Console.WriteLine("Thank you for using the calculator.");
            }

        }
    }
    
}

