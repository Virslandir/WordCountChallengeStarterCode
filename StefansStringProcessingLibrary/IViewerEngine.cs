namespace StefansStringProcessingLibrary
{
    public interface IViewerEngine
    {
        void DisplayMostUsedCharacter(string text);
        void DisplayMostUsedWord(string text);
        void DisplayTotalCharacterCount(string text);
        void DisplayTotalCharacterCountMinusLineReturnsAndWhitespaces(string text);
        void DisplayTotalWordCount(string text);
    }
}