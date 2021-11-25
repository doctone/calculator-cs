﻿using System;

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

        static void OfferRepeat()
        {
            Console.Write("Would you like to do another operation? Y/N: ");
            string answer = Console.ReadLine();
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

        static string GetInput()
        {
            string input = Console.ReadLine();
            return input;

        }

        static void WelcomeMessage()
        {
            Console.WriteLine("=== Welcome to Calculator Land ===");
            Console.Write("What is your name? ");
            string userName = GetInput();
            Console.WriteLine("Welcome, {0}. We hope you enjoy using your new Calculator", userName);
        }


        static void Operation()
        {
            Console.WriteLine("Choose an operation : +  -  *  /");
            string operation = GetInput();

            Console.Write("How many numbers would you like to '{0}'?", operation);
            int numOfOperations = int.Parse(Console.ReadLine());
            int[] nums = new int[numOfOperations];
            for (int i = 0; i < numOfOperations; i++)
            {
                Console.Write("Please enter number {0}: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());

            }

            if (operation == "+")
            {
                Console.WriteLine(Add(nums));
            }
            if (operation == "-")
            {
                Console.WriteLine(Minus(nums));
            }
            if (operation == "/")
            {
                Console.WriteLine(Divide(nums));
            }
            if (operation == "*")
            {
                Console.WriteLine(Mult(nums));
            }
        }


        static int Add(int[] arr)
        {
            int answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                answer += arr[i];
            }
            return answer;
        }

        static int Minus(int[] arr)
        {
            int answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                answer -= arr[i];
            }
            return answer;
        }

        static double Divide(int[] arr)
        {
            int answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                answer /= arr[i];
            }
            return answer;
        }

        static int Mult(int[] arr)
        {
            int answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                answer *= arr[i];
            }
            return answer;
        }
    }
    
}

