using System.Formats.Asn1;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            DisplayPlayerLevel();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
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
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please select from (1-6)");
            }

            Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());


        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));

        }

        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        else
        {
            Console.WriteLine("Invalid goal type!");
        }


    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }

        else
        {
            Console.WriteLine("Invalid goal choice!");
        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);

            }

            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eternalGoal);
            }

            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));

                checklistGoal.LoadProgress(int.Parse(parts[4]));
                _goals.Add(checklistGoal);
            }


        }

        Console.WriteLine("Goals loaded.");
    }

    public void DisplayPlayerLevel()
    {
        string level = "Beginner";

        if (_score >= 1000)
        {
            level = "Legend";
        }

        else if (_score >= 800)
        {
            level = "Champion";
        }

        else if (_score >= 600)
        {
            level = "Explorer";
        }

        else if (_score >= 400)
        {
            level = "Achiever";
        }

        else if (_score >= 200)
        {
            level = "Learner";
        }

        Console.WriteLine($"You are a {level}!");
    }
}