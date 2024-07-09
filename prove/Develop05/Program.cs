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