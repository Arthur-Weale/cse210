
// *********************
// GoalManager Class - Handles menu, goals, score, and file I/O.
// *********************
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        // Modified menu loop: score and level always shown at the top.
        while (running)
        {
            // Always display current score and level first.
            DisplayPlayerInfo();

            Console.WriteLine("\n===== Eternal Quest Menu =====");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListGoalDetails();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }
    }

    // Always displays player's score and corresponding level.
    private void DisplayPlayerInfo()
    {
        int level = _score / 1000;
        Console.Clear();
        Console.WriteLine("=== Eternal Quest ===");
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Current Level: {level}");
        Console.WriteLine("=====================\n");
    }

    private void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available yet.");
            return;
        }
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for each event: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selection.");
                return;
        }
        Console.WriteLine("Goal successfully created!");
    }

    private void RecordGoalEvent()
    {
        ListGoalDetails();
        if (_goals.Count == 0)
        {
            return;
        }
        Console.Write("Select the number of the goal you accomplished: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        int pointsEarned = _goals[goalIndex].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points for that achievement!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save the player's score on the first line.
            writer.WriteLine(_score);
            // Write each goal on a new line.
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file. Press any key to continue...");
        Console.ReadKey();
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Press any key to continue...");
            Console.ReadKey();
            return;
        }
        using (StreamReader reader = new StreamReader(filename))
        {
            // First line is the player's score.
            string scoreLine = reader.ReadLine();
            _score = int.Parse(scoreLine);
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal sg = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            sg.RecordEvent();
                        }
                        _goals.Add(sg);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                        // For simplicity, the count isn't replayed exactly.
                        _goals.Add(cg);
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded from file. Press any key to continue...");
        Console.ReadKey();
    }
}
