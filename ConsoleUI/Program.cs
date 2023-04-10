using CoreLib;
using System;
using System.Collections.Generic;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var runnerFactory = new RunnerFactory();

            var runnerTest = runnerFactory.CreateRunner(RunnerFactory.RunnerType.Test);
            var runnerUser = runnerFactory.CreateRunner(RunnerFactory.RunnerType.User);

            Console.WriteLine($"\n --- Run test data --- \n");
            runnerTest.Run(1);
            
            Console.WriteLine($"\n --- Run user data --- \n");
            runnerUser.Run();

            Console.WriteLine($"\n --- Press any key to exit --- \n");
            Console.ReadLine();
        }  
    }
}