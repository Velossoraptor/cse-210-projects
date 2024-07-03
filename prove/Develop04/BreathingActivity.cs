using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);
        while (DateTime.Now < future)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            if (DateTime.Now < future)
            {
                Console.Write("Breath out...");
                ShowCountDown(5);
                Console.WriteLine();
            }
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}