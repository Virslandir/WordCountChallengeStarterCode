using System;
using CoreLib;

namespace ConsoleUI
{
    public class Runner
    {
        private readonly IDataService _dataService;

        public Runner(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void Run()
        {
            Console.WriteLine(_dataService.DisplayTotalWordCount("Hello World"));
            consoleViewer.DisplayTotalWordCount(text1);
            consoleViewer.DisplayTotalCharacterCount(text1);
            consoleViewer.DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(text1);
            consoleViewer.DisplayMostUsedWord(text1);
            consoleViewer.DisplayMostUsedCharacter(text1);
        }
    }
}