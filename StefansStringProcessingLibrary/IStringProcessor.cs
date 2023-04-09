using System.Collections.Generic;

namespace StefansStringProcessingLibrary
{
    public interface IStringProcessor
    {
        string[] GetAllWords(string text);
        char GetMostAppearingCharacter(string text);
        Dictionary<char, int> GetMostAppearingCharacters(string text);
        int GetMostNumberOfCharacterAppearances(string text);
        int GetMostNumberOfWordAppearances(string text);
        string GetMostUsedWord(string text);
        Dictionary<string, int> GetMostUsedWords(string text);
        int GetTotalCharacterCount(string text);
        int GetTotalCharacterCountWithoutWhitespacesAndLineReturns(string text);
        int GetTotalWordCount(string text);
    }
}