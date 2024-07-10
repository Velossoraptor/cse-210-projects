// creativity: I added a level tracking to the code, every 1000 points you level up, starting at level 1. it then resets your points.

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        GoalManager goalManager = new GoalManager();
        Console.Clear();
        goalManager.Start(run);
    }
}