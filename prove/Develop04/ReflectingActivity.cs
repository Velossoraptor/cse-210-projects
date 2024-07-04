public class ReflectingActivity : Activity
{
    private List<String> _prompts = new List<String>();
    private List<String> _questions = new List<String>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready...");
        ShowSpinner(5);
        DisplayPrompt();
        Console.WriteLine("Once you've thought of an answer to the prompt, press enter.");
        Console.ReadLine();
        Console.Write("Get ready to reflect...");
        ShowSpinner(3);

        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);

        while (DateTime.Now < future)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public String GetRandomPrompt()
    {
        Random rnd = new Random();
        int indx = rnd.Next(0, _prompts.Count);
        String prompt = _prompts[indx];
        return prompt;
    }

    public String GetRandomQuestion()
    {
        Random rnd = new Random();
        int indx = rnd.Next(0, _questions.Count);
        String question = _questions[indx];
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}