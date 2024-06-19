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
                userJournal._entries.Add(testEntry);
            }
            else if (userInput == 2)
            {
                userJournal.Display();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Unfinished option, quitting.");
                break;
            }
            else if (userInput == 4)
            {
                Console.Write("Where would you like to save? (filename, no extension): ");
                String filename = Console.ReadLine() + ".csv";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine("/*Date, Prompt, Response*/");
                    foreach (Entry entry in userJournal._entries)
                    {
                        // needs to write each entry in date, prompt, response format
                        String date = entry._date;
                        String prompt = entry._prompt;
                        String response = entry._response;
                        outputFile.WriteLine($"{date},{prompt},{response}");
                    }
                }
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