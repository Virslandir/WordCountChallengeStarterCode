using System;
using CoreLib;

namespace ConsoleUI
{
    public class Runner
    {
        private readonly IDataService _dataService;
        private readonly IDataProvider _dataProvider;

        public Runner(IDataService dataService, IDataProvider dataProvider)
        {
            _dataService = dataService;
            _dataProvider = dataProvider;
        }

        public void Run(int sampleNumber = 0)
        {
            string[] data = _dataProvider.GetSample();
            string sample = data[sampleNumber];
            
            Console.WriteLine(_dataService.DisplayTotalWordCount(sample));
            Console.WriteLine(_dataService.DisplayTotalCharacterCount(sample));
            Console.WriteLine(_dataService.DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(sample));
            Console.WriteLine(_dataService.DisplayMostUsedWord(sample));
            Console.WriteLine(_dataService.DisplayMostUsedCharacter(sample));
        }
    }
}