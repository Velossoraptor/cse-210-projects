using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int listingCount = 0;
        int reflectingCount = 0;
        bool run = true;
        Console.Clear();

        Console.WriteLine("Wecome to the Mindfulness Program!");

        while (run)
        {
            Console.Clear();
            Console.WriteLine("Please Choose one of the following options by number: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing acitivity");
            Console.WriteLine("4. Quit");
            int userIn = int.Parse(Console.ReadLine());

            if (userIn == 1)
            {
                BreathingActivity bActivity = new BreathingActivity();
                bActivity.Run();
                breathingCount++;
                Console.WriteLine($"You've completed this activity {breathingCount} times!");
            }
            else if (userIn == 2)
            {
                ReflectingActivity rActivity = new ReflectingActivity();
                rActivity.Run();
                reflectingCount++;
                Console.WriteLine($"You've completed this activity {reflectingCount} times!");
            }
            else if (userIn == 3)
            {
                ListingActivity lActivity = new ListingActivity();
                lActivity.Run();
                listingCount++;
                Console.WriteLine($"You've completed this activity {listingCount} times!");
            }
            else if (userIn == 4)
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}