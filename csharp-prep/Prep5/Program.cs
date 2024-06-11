using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squared = SquareNumber(userNum);
        DisplayResult(userName, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your username?: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number?: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, your number squared is {squared}.");

    }
}