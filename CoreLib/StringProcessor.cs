using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoreLib
{
    public class StringProcessor : IStringProcessor
    {
        private readonly Regex _regex;
        
        public StringProcessor(RegexProvider regexProvider)
        {
            _regex = regexProvider.CreateRegex();
        }
        
        
        private string ConvertToWordsAndWhitespace(string text)
        {
            string textWithoutLineReturns = ReplaceLineReturns(text);

            return _regex.Replace(textWithoutLineReturns, "");
        }

        public string[] GetAllWords(string text)
        {
            string[] wordsOnly = ConvertToWordsAndWhitespace(text).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return wordsOnly;
        }

        public int GetTotalWordCount(string text)
        {
            return GetAllWords(text).Length;
        }

        public Dictionary<char, int> GetMostAppearingCharacters(string text)
        {
            Dictionary<char, int> charOccurences = CreateCharOccuranceDictionary(string.Concat(GetAllWords(text)));
            Dictionary<char, int> mostUsedChars = GetMostAppearingKeys(charOccurences);

            return mostUsedChars;
        }

        public Dictionary<string, int> GetMostUsedWords(string text)
        {
            string[] allWords = GetAllWords(text);

            Dictionary<string, int> wordOccurences = CreateStringOccuranceDictionary(allWords);
            Dictionary<string, int> mostUsedWords = GetMostAppearingKeys(wordOccurences);

            return mostUsedWords;
        }

        public string GetMostUsedWord(string text)
        {
            return GetMostUsedWords(text).First().Key;
        }

        public char GetMostAppearingCharacter(string text)
        {
            return GetMostAppearingCharacters(text).First().Key;
        }

        public int GetMostNumberOfWordAppearances(string text)
        {
            return GetMostUsedWords(text).First().Value;
        }

        public int GetMostNumberOfCharacterAppearances(string text)
        {
            return GetMostAppearingCharacters(text).First().Value;
        }

        private Dictionary<string, int> GetMostAppearingKeys(Dictionary<string, int> dict)
        {
            int mostAppearances = dict.Values.Max();
            var mostAppearingKeys = dict.Where(x => x.Value == mostAppearances).ToDictionary(x => x.Key, y => y.Value);

            return mostAppearingKeys;
        }

        private Dictionary<char, int> GetMostAppearingKeys(Dictionary<char, int> dict)
        {
            int mostAppearances = dict.Values.Max();
            var mostAppearingKeys = dict.Where(x => x.Value == mostAppearances).ToDictionary(x => x.Key, y => y.Value);

            return mostAppearingKeys;
        }

        private Dictionary<string, int> CreateStringOccuranceDictionary(string[] words)
        {
            Dictionary<string, int> wordOccurences = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string dictEntry = item.ToLower();

                if (!wordOccurences.ContainsKey(dictEntry))
                {
                    wordOccurences.Add(dictEntry, 1);
                }
                else
                {
                    int counter = wordOccurences[dictEntry];
                    counter++;
                    wordOccurences[dictEntry] = counter;
                }
            }

            return wordOccurences;
        }

        private Dictionary<char, int> CreateCharOccuranceDictionary(string text)
        {
            Dictionary<char, int> charOccurences = new Dictionary<char, int>();

            foreach (var letter in text.ToLower())
            {
                char dictEntry = letter;

                if (!charOccurences.ContainsKey(dictEntry))
                {
                    charOccurences.Add(dictEntry, 1);
                }
                else
                {
                    int counter = charOccurences[dictEntry];
                    counter++;
                    charOccurences[dictEntry] = counter;
                }
            }

            return charOccurences;
        }

        private string ReplaceLineReturns(string text, string replacementForLineReturn = " ")
        {
            return text.Replace(Environment.NewLine, replacementForLineReturn);
        }

        public int GetTotalCharacterCount(string text)
        {
            return ReplaceLineReturns(text).Length;
        }

        public int GetTotalCharacterCountWithoutWhitespacesAndLineReturns(string text)
        {
            return ReplaceLineReturns(text).Replace(" ", "").Length;
        }
    }
}