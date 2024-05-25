public class ChecklistGoal : Goal
{
    protected int _counter;
    protected int _goalTimes;
    protected int _bonusPoints;


    public ChecklistGoal()
    {

    }
    public ChecklistGoal(string goalName, string goalDescription, int points, bool status, int bonusPoints, int goalTimes, int counter) : base(goalName, goalDescription, points)
    {
        _status = status;
        _counter = counter;
        _goalTimes = goalTimes;
        _bonusPoints = bonusPoints;

    }

    public override void DisplayStartMessage()
    {
        CreateStartMessage();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string GoalBonusTimes = Console.ReadLine();
        _goalTimes = int.Parse(GoalBonusTimes);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string BonusPoints = Console.ReadLine();
        _bonusPoints = int.Parse(BonusPoints);

        _counter = 0;
    }

    public override bool IsComplete()
    {
        if (_counter >= _goalTimes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void ListGoal(int i)
    {
        string notCompleteSymbol = "";
        bool status = IsComplete();
        if (status == true)
        {
            notCompleteSymbol = "X";
        }
        else
        {
            notCompleteSymbol = " ";
        }
        Console.WriteLine($"[{notCompleteSymbol}] {_goalName} ({_goalDescription}) -- Currently completed: {_counter}/{_goalTimes}");
    }

    public override string SaveGoal()
    {
        string goalLine = " ";
        goalLine = $"ChecklistGoal~{_goalName}~{_goalDescription}~{_points}~{_status}~{_bonusPoints}~{_goalTimes}~{_counter}";
        return goalLine;
    }

    public override int CalculateTotalPoint()
    {
        int points = 0;

        points = _counter * _points;

        bool status = IsComplete();

        if (status == true)
        {
            points += _bonusPoints;
        }

        return points;

    }

    public override void RecordEvent()
    {
        _counter++;
    }



}