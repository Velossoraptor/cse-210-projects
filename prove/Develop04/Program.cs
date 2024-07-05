using System;
// Creativity: Each activity keeps track of how many times it has been completed within the program, 
// and reports it each time you've completed the activity again.
class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        BreathingActivity bActivity = new BreathingActivity();
        ReflectingActivity rActivity = new ReflectingActivity();
        ListingActivity lActivity = new ListingActivity();
        Console.Clear();

        Console.WriteLine("Wecome to the Mindfulness Program!");

        while (run)
        {
            Console.WriteLine("Please Choose one of the following options by number: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing acitivity");
            Console.WriteLine("4. Quit");
            int userIn = int.Parse(Console.ReadLine());

            if (userIn == 1)
            {
                bActivity.Run();
            }
            else if (userIn == 2)
            {
                rActivity.Run();
            }
            else if (userIn == 3)
            {
                lActivity.Run();
            }
            else if (userIn == 4)
            {
                run = false;
                Console.WriteLine("Goodbye!");
                Thread.Sleep(5000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}