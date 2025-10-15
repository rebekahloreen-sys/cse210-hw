public class GoalManager
{
    private List<List<Goal>> _goals = new List<List<Goal>>();
    private int _score;
    private Goal _newG = null;
    private bool _gameLoop = true;
   

    public GoalManager()
    {

    }
    public void Start()
    {
        Console.Clear();
        while (_gameLoop == true)
        {
            
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.Write("Please pick another option.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Your score is {_score}");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (var goalList in _goals)
        {
            foreach (var goal in goalList)
            {
                Console.WriteLine($"{index}. {goal.GetName()}");
                index++;
            }
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        foreach (var goalList in _goals)
        {
            foreach (var goal in goalList)
            {
                if (goal.IsComplete() == true)
                {
                    Console.Write("[X]");
                }
                else
                {
                    Console.Write("[ ]");
                }
                
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal would you like to add?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter how many points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _newG = new SimpleGoal(name, description, points, false);
        }
        else if (goalType == "2")
        {
            _newG = new EternalGoal(name, description, points);
        }
        else if (goalType == "3")
        {
            Console.Write("Enter times to complete: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _newG = new ChecklistGoal(name, description, points, target, bonus, 0);
        }

        _goals.Add(new List<Goal>{_newG});        
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal do you want to mark off? ");
        ListGoalNames();
        int choice = int.Parse(Console.ReadLine());

        Goal goalChoice = _goals[choice - 1][0];
        goalChoice.RecordEvent();
        
        Console.WriteLine($"You got {goalChoice.GetPoints()} points!");
        if (goalChoice is ChecklistGoal checklist)
        {
            if (checklist.IsComplete() == true)
            {
                _score += checklist.GetBonus();
                Console.WriteLine();
                Console.WriteLine($"You got a bonus of {checklist.GetBonus()} points!");
            }
        }
        _score += goalChoice.GetPoints();
    }
    public void SaveGoals()
    {
        Console.Write("What is the name of the file you would like to save this to? ");
        string filePath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Score: {_score}");
            foreach (List<Goal> goalList in _goals)
            {
                foreach (Goal goal in goalList)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the name of the file you would like to load from? ");
        string filePath = Console.ReadLine();

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0) return;

        _goals = new List<List<Goal>>();

        string firstLine = lines[0].Trim();
        if (firstLine.StartsWith("Score:"))
        {
            _score = int.Parse(firstLine.Split(':')[1].Trim());
        }
        else
        {
            _score = 0;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string rawLine = lines[i].Trim();
            if (string.IsNullOrEmpty(rawLine)) continue;

            string[] parts = rawLine.Split(new[] { ':' }, 2);
            if (parts.Length < 2)
            {
                Console.WriteLine($"Skipping malformed line (no type delimiter): {rawLine}");
                continue;
            }

            string goalType = parts[0].Trim();
            string payload = parts[1].Trim();
            string[] fields = payload.Split('|');

            Goal newGoal = null;

            if (goalType == "SimpleGoal")
            {
                string name = fields[0];
                string description = fields[1];
                int points = int.Parse(fields[2]);
                bool isComplete = bool.Parse(fields[3]);

                newGoal = new SimpleGoal(name, description, points, isComplete);
            }
            else if (goalType == "EternalGoal")
            {
                string name = fields[0];
                string description = fields[1];
                int points = int.Parse(fields[2]);

                newGoal = new EternalGoal(name, description, points);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = fields[0];
                string description = fields[1];
                int points = int.Parse(fields[2]);
                bool isComplete = bool.Parse(fields[3]);
                int target = int.Parse(fields[4]);
                int bonus = int.Parse(fields[5]);
                int amountCompleted = int.Parse(fields[6]);

                newGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
            }
            else
            {
                Console.WriteLine($"Unknown goal type '{goalType}' — skipping line.");
                continue;
            }

            _goals.Add(new List<Goal> { newGoal });
        }
    }
    
}