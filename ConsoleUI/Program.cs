using CoreLib;
using System;
using System.Collections.Generic;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexProvider = new RegexProvider();
            var stringProcessor = new StringProcessor(regexProvider);
            var dataService = new DataService(stringProcessor);
            
            var testDataProvider = new TestDataProvider();
            var userDataProvider = new UserDataProvider();
            
            var runnerTest = new Runner(dataService, testDataProvider);
            var runnerUser = new Runner(dataService, userDataProvider);

            Console.WriteLine($"\n --- Run test data --- \n");
            runnerTest.Run(1);
            
            Console.WriteLine($"\n --- Run user data --- \n");
            runnerUser.Run();

            Console.WriteLine($"\n --- Press any key to exit --- \n");
            Console.ReadLine();
        }  
    }
}