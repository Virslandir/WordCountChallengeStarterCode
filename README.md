# WordCountChallengeStarterCode
This console app will provide the following info for a given string:
  - total word count
  - total character count
  - most used word(s) with number of occurences
  - most used character with number of occurences

The app was made as an excercise for Tim Corey's "C# Algorithms & Data Structures" course, but I have also introduced loose coupling and abstractions throught interfaces, as an additional exercise.

For the string processing purposes a StringProcessor class is used, or rather, the IStringProcessor interface, which allows easy replacement of the current implementation with a future alternative.

The UI component (the console in the current case) is also abstracted away by use of the IViewerEngine interface, and I have yet to test other UI possibilities, say, a WinForms or maybe a Razor Pages variation, to see how easy it actually is to replace the UI with this interface.

Additionally, I have tried to implement the Dependency Inversion Principle (DIP) by using a Factory class which is solely responsible for instantiating all dependencies. The only "newing up" happening outside of the Factory is when the Main method instantiates the Factory itself.


I am happy and open to hear comments and critique from the community.

Target Framework: .NET Framework 4.7.2
