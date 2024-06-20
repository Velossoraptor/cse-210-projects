using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        Journal userJournal = new Journal();


        while (userInput != 5)
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select on of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load from Existing Journal");
            Console.WriteLine("4. Save/Overwrite Existing Journal");
            Console.WriteLine("5. Quit");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Please enter a journal entry based on the prompt!");
                Entry testEntry = new Entry();
                testEntry.EnterResponse();
                userJournal.AddEntry(testEntry);
            }
            else if (userInput == 2)
            {
                userJournal.Display();
            }
            else if (userInput == 3)
            {
                Console.Write("Where would you like to load from? (filename and extension): ");
                String filename = Console.ReadLine();
                userJournal.LoadFromFile(filename);
            }
            else if (userInput == 4)
            {
                Console.Write("Where would you like to save? (filename, no extension): ");
                String filename = Console.ReadLine() + ".csv";
                userJournal.SaveToFile(filename);
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option:");
            }
        }

    }
}