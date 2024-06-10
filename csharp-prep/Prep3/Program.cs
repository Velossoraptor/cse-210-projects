using System;

class Program
{
    static void Main(string[] args)
    {
        bool cont = true;
        Random randomGenerator = new Random();


        while (cont == true)
        {
            int secretNum = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int numGuesses = 0;
            while (userGuess != secretNum)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                Console.WriteLine(secretNum);

                if (userGuess > secretNum)
                {
                    Console.WriteLine("Lower...");
                }
                else if (userGuess < secretNum)
                {
                    Console.WriteLine("Higher...");
                }
                else if (userGuess == secretNum)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You used {numGuesses + 1} guesses! ");
                    break;
                }
                numGuesses++;
            }
            Console.Write("Would you like to continue? ");
            string contin = Console.ReadLine();
            if (contin == "y" || contin == "Y" || contin == "yes" || contin == "Yes")
            {
                cont = true;
            }
            else if (contin == "n" || contin == "N" || contin == "no" || contin == "No")
            {
                Console.WriteLine("Goodbye!");
                cont = false;
            }
        }

    }
}