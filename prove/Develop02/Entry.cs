using System.Net;

public class Entry()
{
    public String _prompt = "";
    public String _response = "";
    static DateTime _currentDate = DateTime.Now;
    public String _date = _currentDate.ToShortDateString();
    PromptGenerator prompts = new PromptGenerator();

    public void EnterResponse()
    {
        _prompt = prompts.Prompt();
        Console.Write($"{_prompt} \n>");
        _response = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }


}