namespace ConsoleUI
{
    public class TestDataProvider : IDataProvider
    {
        public string[] GetSample() => new string[]
        {
            @"The test of the 
            best way to handle

multiple lines,   extra spaces and more.",
            @"Using the starter app, create code that will 
loop through the strings and identify the total 
character count, the number of characters
excluding whitespace (including line returns), and the
number of words in the string. Finally, list each word, ensuring it
is a valid word.",
            "The test of the \n            best way to handle\n\nmultiple lines,   extra spaces and more.",
            "Using the starter app, create code that will \nloop through the strings and identify the total \ncharacter count, the number of characters\nexcluding whitespace (including line returns), and the\nnumber of words in the string. Finally, list each word, ensuring it\nis a valid word."
        };

        /* 
            First string (textToProcess) Values:
            Total Words: 14
            Total Characters: 89
            Character count (minus line returns and spaces): 60
            Most used word: the (2 times)
            Most used character: e (10 times)

            Second string (tests[1]) Values:
            Total Words: 45
            Total Characters: 276
            Character count (minus line returns and spaces): 230
            Most used word: the (6 times)
            Most used character: t (24 times)
        */
    }
}