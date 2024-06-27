using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: Program reminds users to practice in two days at the end
        DateTime now = DateTime.Today;
        String nextPractice = now.AddDays(2).ToString();
        Boolean run = true;
        Reference exampleReference = new Reference("Mosiah", 3, 19);
        Scripture exampleScripture = new Scripture(exampleReference, "Put off the natural man and become a saint unto the lord.");

        Console.WriteLine("Your Scripture is:");

        while (run)
        {
            Console.WriteLine(exampleScripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to end");
            String userIn = Console.ReadLine();

            if (userIn == "")
            {
                if (exampleScripture.IsCompletelyHidden())
                {
                    Console.WriteLine($"Don't forget to practice on {nextPractice}!");
                    run = false;
                    break;
                }
                Console.Clear();
                exampleScripture.HideRandomWords(3);
            }
            else if (userIn == "quit")
            {
                Console.WriteLine($"Don't forget to practice on {nextPractice}!");
                run = false;
                break;
            }
        }
    }
}