namespace CoreLib
{
    public interface IDataService
    {
        string DisplayMostUsedCharacter(string text);
        string DisplayMostUsedWord(string text);
        string DisplayTotalCharacterCount(string text);
        string DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(string text);
        string DisplayTotalWordCount(string text);
    }
}