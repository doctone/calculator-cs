using System;
using System.IO;
namespace HelloWorld
{
    public class NumCalculator
    {
        public static void NumOperation()
        {
            string operation = Program.GetInput("Choose an operation : + - * /");

            int numOfOperations = Program.AskForNum("How many times would you like to perform this operation?");
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

            string answerToLog = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length-1)
                {
                    answerToLog += (nums[i] + "\n  = \n");
                }
                else
                {
                    answerToLog += (nums[i] + " " + operation + "\n");
                }
            }
            answerToLog += answer;
            Program.LogText(answerToLog);
        }
    }
}
