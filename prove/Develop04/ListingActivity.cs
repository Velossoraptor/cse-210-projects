public class ListingActivity : Activity
{
    private int _count = 0;
    private List<String> _prompts = new List<String>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready...");
        ShowSpinner(5);
        GetRandomPromt();
        Console.Write("Think about your prompt...");
        ShowCountDown(10);
        Console.WriteLine("GO!!");

        List<String> entries = GetListFromUser();
        _count = entries.Count;
        Console.WriteLine("Finished!");
        Console.WriteLine($"You entered {_count} items!");
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRandomPromt()
    {
        Random rnd = new Random();
        int indx = rnd.Next(0, _prompts.Count);
        String prompt = _prompts[indx];
        Console.WriteLine(prompt);
    }

    public List<String> GetListFromUser()
    {
        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);
        List<String> entries = new List<String>();

        while (DateTime.Now < future)
        {
            Console.Write("> ");
            String entry = Console.ReadLine();
            entries.Add(entry);
        }
        return entries;
    }
}