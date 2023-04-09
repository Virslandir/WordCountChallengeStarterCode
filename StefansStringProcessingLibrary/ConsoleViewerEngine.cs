using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefansStringProcessingLibrary
{
    public class ConsoleViewerEngine : IViewerEngine
    {
        private readonly IStringProcessor _processor;

        public ConsoleViewerEngine(IStringProcessor processor)
        {
            _processor = processor;
        }

        public void DisplayTotalWordCount(string text)
        {
            Console.WriteLine($"Total Words: {_processor.GetTotalWordCount(text)}");
        }
        public void DisplayTotalCharacterCount(string text)
        {
            Console.WriteLine($"Total characters: {_processor.GetTotalCharacterCount(text)}");
        }

        public void DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(string text)
        {
            Console.WriteLine($"Character count (minus line returns and spaces): {_processor.GetTotalCharacterCountWithoutWhitespacesAndLineReturns(text)}");
        }

        public void DisplayMostUsedWord(string text)
        {
            Console.WriteLine($"Most used word: {_processor.GetMostUsedWord(text)} ({_processor.GetMostNumberOfWordAppearances(text)} times)");
        }

        public void DisplayMostUsedCharacter(string text)
        {
            Console.WriteLine($"Most appearing character: {_processor.GetMostAppearingCharacter(text)}" +
                $" ({_processor.GetMostNumberOfCharacterAppearances(text)} times)");
        }
    }
}
