using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption = -1;
        int userGoalType = -1;

        GoalEntry goals = new GoalEntry();

        while (userOption != 6)
        {
            int totalpoints = goals.GetTotalPoints();
            Console.WriteLine($"\nYou have {totalpoints} points.");
            Console.WriteLine("\nMore Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Events");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string Option = Console.ReadLine();
            userOption = int.Parse(Option);
            if (userOption == 1)
            {
                Console.WriteLine("The type of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                userGoalType = int.Parse(goalType);
                if (userGoalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.DisplayStartMessage();
                    goals.AddGoal(simpleGoal);
                }
                else if (userGoalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.DisplayStartMessage();
                    goals.AddGoal(eternalGoal);
                }
                else if (userGoalType == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.DisplayStartMessage();
                    goals.AddGoal(checklistGoal);
                }

            }
            else if (userOption == 2)
            {
                goals.ListGoals();
            }
            else if (userOption == 3)
            {
                goals.SaveGoals();
            }
            else if (userOption == 4)
            {
                goals.LoadGoals();
            }
            else if (userOption == 5)
            {
                goals.RecordEventEntry();
            }
            else if (userOption == 6)
            {
                Console.Write("Keep working on your Goals");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Goodbye!!");
            }

        }
    }
}
