public class GoalEntry
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public int GetTotalPoints()
    {
        int totalPoints = _totalPoints;
        return totalPoints;
    }
    public int CalculateTotalPoints()
    {
        int totalPoints = _totalPoints;
        foreach (Goal goal in _goals)
        {
            totalPoints += goal.CalculateTotalPoint();
        }
        _totalPoints = totalPoints;

        return totalPoints;
    }


    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file? ");
        string userFileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            int totalP = GetTotalPoints();
            outputFile.WriteLine(totalP.ToString());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }

        Console.Write("Saving To File");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine($"\nSuccessfully saved to {userFileName}");
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        string userFileName = Console.ReadLine();
        Console.Write("Reading From File");

        if (File.Exists(userFileName))
        {
            string[] lines = System.IO.File.ReadAllLines(userFileName);

            int _totalPoints = int.Parse(lines[0]);
            lines = lines.Skip(1).ToArray();
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

            

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                    _goals.Add(simpleGoal);
                }
                if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eternalGoal);
                }
                if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    _goals.Add(checklistGoal);
                }
            }
            for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"\nSuccessfully loaded from {userFileName}");
        }


    }


    public void RecordEventEntry()
    {
        ListGoals();

        Console.Write("Which goal did you accomplish? ");
        string goalIndex = Console.ReadLine();
        int goalIndexInt = int.Parse(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false)
        {
            _goals[goalIndexInt].RecordEvent();

            int userPoints = _goals[goalIndexInt].CalculateTotalPoint();

            _totalPoints += userPoints;

            Console.WriteLine($"Congratulations! You have earned {userPoints.ToString()} points!");
            Console.WriteLine($"You now have {_totalPoints} points");

        }
        else
        {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}