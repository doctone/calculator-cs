using System;
using System.IO;

namespace HelloWorld
{
    class Log
    {
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
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(message); ;
                    sw.WriteLine("-------------");
                }
            }

        }
    }
    
}
