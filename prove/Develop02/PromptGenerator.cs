public class PromptGenerator(){
    static List<string> _prompts = new List<string>{"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
    "What made me smile today?", "What things stressed me out today?", "What things do I need to reflect on?",
    "How can I improve on one thing tomorrow?"};

    public String Prompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        String _prompt = _prompts[index];
        return _prompt;
    }
}