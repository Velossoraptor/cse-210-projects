public class GoalManager {
    private List<Goal> _goals;
    private int _score;

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start(bool run){
        while(run){
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
            if(userInput == 1){
                CreateGoal();
                Console.Clear();
            }else if(userInput == 2){
                Console.Clear();
                ListGoalDetails();
                Console.WriteLine();
            }else if(userInput == 3){
                SaveGoals();
            }else if(userInput == 4){
                LoadGoals();
            }else if(userInput == 5){
                RecordEvent();
            }else if(userInput == 6){
                Console.WriteLine("Goodbye");
                run = false;
                break;
            }else{
                Console.WriteLine("Invalid input");
            }
        }
        
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames(){
        Console.WriteLine("Your Goals are: ");
        int count = 0;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }
    }

    public void ListGoalDetails(){
        Console.WriteLine("Your Goals: ");
        int count = 1;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal(){
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

        if(userInput == 1){
            _goals.Add(new SimpleGoal(name, description, points));
        }else if (userInput == 2){
            _goals.Add(new EternalGoal(name, description, points));
        }else if (userInput == 3){
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }else{
            Console.WriteLine("Invalid input");
        }
    }

    public void RecordEvent(){
        Console.Clear();
        ListGoalDetails();
        Console.Write("Which goal did you complete?: ");
        int userInput = int.Parse(Console.ReadLine());

        _score += _goals[userInput-1].RecordEvent();
        Console.Clear();
    }

    public void SaveGoals(){

    }

    public void LoadGoals(){

    }
}