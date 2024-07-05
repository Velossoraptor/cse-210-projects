using System.Globalization;

public class Activity
{
    protected String _name = "";
    protected String _description = "";
    protected int _duration = 0;

    public Activity()
    {
        _name = "default";
        _description = "unknown";
        _duration = 10;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long would you like to perform the activity in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
    }
    public void ShowSpinner(int seconds)
    {
        // double secondsCounter = 0;
        List<String> spinnerStrings = new List<String>{
            " (*    )",
            " ( *   )",
            "(   *  )",
            "(    * )",
            "(     *)",
            "(    * )",
            "(    * )",
            "(     *)",
            "(     *)",
            "(    *) ",
            "(   * ) ",
            "(  *   )",
            "( *    )",
            "(*     )",
            "( *    )",
            "( *    )",
            "(*     )",
            "(*     )",
            };
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            // The cursor is set to invisible to prevent unnecessary flashing when displaying the loading animation
            Console.CursorVisible = false;
            String spinnerFrame = spinnerStrings[i];
            Console.Write(spinnerFrame);
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 8, Console.CursorTop);
            // Researched this /\ method as the \b method resulted in lots of strobing and annoying flashing with the spinner as 
            // it's such a long sequence

            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
        Console.Write("        \b\b\b\b\b\b\b\b");
        Console.WriteLine();
        Console.CursorVisible = true;
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            int numSec = i;
            int count = 0;
            Console.Write(i);
            Thread.Sleep(1000);
            while (numSec != 0)
            {
                //Determines the number of digits in the seconds countdown
                numSec = numSec / 10;
                if (numSec < 1)
                {
                    break;
                }
                count++;
            }
            // For each digit it moves the cursor back
            for (int j = count; j >= 0; j--)
            {
                Console.Write("\b");
            }
            // For each digit it prints a space
            for (int j = count; j >= 0; j--)
            {
                Console.Write(" ");
            }
            // For each digit it moves the cursor back
            for (int j = count; j >= 0; j--)
            {
                Console.Write("\b");
            }
        }
    }
}