using System;
namespace HelloWorld
{
    public class DateCalculator
    {

        public static void DateOperation()
        {
            string dateInput = Program.GetInput("Please enter a date");
            DateTime date = DateTime.Parse(dateInput);
            int toAdd = int.Parse(Program.GetInput("Enter the number of days you wish to add: "));
            Console.WriteLine($"Your answer is {date.AddDays(toAdd)}");

        }
    }
}