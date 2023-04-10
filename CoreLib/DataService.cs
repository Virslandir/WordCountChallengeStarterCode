using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class DataService : IDataService
    {
        private readonly IStringProcessor _processor;

        public DataService(IStringProcessor processor)
        {
            _processor = processor;
        }

        public string DisplayTotalWordCount(string text)
        {
            return ($"Total Words: {_processor.GetTotalWordCount(text)}");
        }
        
        
        public string DisplayTotalCharacterCount(string text)
        {
            return($"Total characters: {_processor.GetTotalCharacterCount(text)}");
        }

        
        public string DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(string text)
        {
            return($"Character count (minus line returns and spaces): {_processor.GetTotalCharacterCountWithoutWhitespacesAndLineReturns(text)}");
        }

        
        public string DisplayMostUsedWord(string text)
        {
            return($"Most used word: {_processor.GetMostUsedWord(text)} ({_processor.GetMostNumberOfWordAppearances(text)} times)");
        }

        
        public string DisplayMostUsedCharacter(string text)
        {
            return($"Most appearing character: {_processor.GetMostAppearingCharacter(text)}" +
                   $" ({_processor.GetMostNumberOfCharacterAppearances(text)} times)");
        }
    }
}