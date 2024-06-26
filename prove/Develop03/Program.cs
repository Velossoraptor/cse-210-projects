using System;

class Program
{
    static void Main(string[] args)
    {
        // Everything is tested and seems to work, just need to add creativity and set up the main loop in this file


        // Word testWord = new Word("Heyo");
        // Console.WriteLine(testWord.GetDisplayText());
        // testWord.Hide();
        // Console.WriteLine(testWord.GetDisplayText());

        Reference testReference = new Reference("Alma", 3, 5);
        // Reference testReference2 = new Reference("Alma", 3, 5, 7);
        // Console.WriteLine(testReference.GetDisplayText());
        // Console.WriteLine(testReference2.GetDisplayText());

        Scripture testScripture = new Scripture(testReference, "Lorem Ipsum pretend this is alma 3:5");
        testScripture.HideRandomWords(2);
        Console.WriteLine(testScripture.GetDisplayText());
        testScripture.HideRandomWords(2);
        Console.WriteLine(testScripture.GetDisplayText());
        testScripture.HideRandomWords(2);
        Console.WriteLine(testScripture.GetDisplayText());
        testScripture.HideRandomWords(2);
        Console.WriteLine(testScripture.GetDisplayText());
    }
}