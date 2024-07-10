using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public void Start(bool run)
    {
        while (run)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                ListGoalDetails();
            }
            else if (userInput == 3)
            {
                SaveGoals();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Goodbye");
                run = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            if(_score >= 1000){
                LevelUp();
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Level: {_level}");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your Goals are: ");
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("Your Goals: ");
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create?: ");
        int userInput = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal?: ");
        String name = Console.ReadLine();
        Console.Write("What is a short description of your goal?: ");
        String description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        String points = Console.ReadLine();

        if (userInput == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (userInput == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (userInput == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid input");
            Thread.Sleep(2000);
        }
        Console.Clear();
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        Console.Write("Which goal did you complete?: ");
        int userInput = int.Parse(Console.ReadLine());

        _score += _goals[userInput - 1].RecordEvent();
        Console.Clear();
    }

    public void LevelUp(){
        _score -= 1000;
        _level++;

        Console.Clear();
        Console.WriteLine("You Leveled Up!");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("Please enter the file you would like to save your goals to: ");
        String filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score},{_level}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("Please enter the file you would like to load your goals from: ");
        String filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        int lineCount = 0;
        _goals.Clear();
        foreach (String line in lines)
        {
            String[] parts = line.Split(",");
            if (lineCount == 0)
            {
                _score = int.Parse(parts[0]);
                _level = int.Parse(parts[1]);
                lineCount++;
            }
            else
            {
                String goalType = parts[0];
                String shortName = parts[1];
                String description = parts[2];
                String points = parts[3];

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(shortName, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int amount = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus, amount));
                }
            }
        }
        Console.WriteLine($"Goals loaded from {filename}!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Clear();
    }
}