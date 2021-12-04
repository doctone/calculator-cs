using System;
using System.IO;

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            string path = @"c:\temp\calculatorlog.txt";
            string choice = WelcomeMessage();
            if (choice == "1")
            {
                NumCalculator.NumOperation();
                OfferRepeat(1, path);
            } else
            {
                DateCalculator.DateOperation();
                OfferRepeat(2, path);
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

        public static void OfferRepeat(int option, string path)
        {
            string answer = GetInput("Would you like to do another operation? Y/N: ");
            if (answer == "Y" || answer == "y")
            {
                if (option == 1)
                {
                    ReadText(path);
                    NumCalculator.NumOperation();
                    OfferRepeat(1, path);
                }
                else
                {
                    ReadText(path);
                    DateCalculator.DateOperation();
                    OfferRepeat(2, path);
                }

            }
            else
            {
                Console.WriteLine("Thank you for using the calculator.");
                File.Delete(path);
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
        public static void LogText(string message)
        {
            string path = @"c:\temp\calculatorlog.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(message);
                    sw.WriteLine("-------------");
                }
            } else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(message); ;
                    sw.WriteLine("-------------");
                }
            }
            
        }
        public static void ReadText(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }


        
        
    
}

