public class Activity
{
    protected String _name = "";
    protected String _description = "";
    protected int _duration = 0;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
    }
    public void ShowSpinner(int seconds)
    {
        double secondsCounter = 0;
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
        while (currentTime < futureTime)
        {
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
            secondsCounter += .1;
            if (secondsCounter >= seconds)
            {
                Console.Write("\b\b\b\b\b\b\b\b        \b\b\b\b\b\b\b\b");
                break;
            }
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}