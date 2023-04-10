using System;

namespace ConsoleUI
{
    public class UserDataProvider : IDataProvider
    {
        public string[] GetSample()
        {
            {
                Console.WriteLine("Input text to process:");
                string text1 = Console.ReadLine();
                string[] tests = new string[] { text1 };
                return tests;
            }
        }
    }
}