public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }
    public SimpleGoal(string goalName, string goalDescription, int points, bool status) : base(goalName, goalDescription, points)
    {
        _status = status;
    }

    public override void DisplayStartMessage()
    {
        CreateStartMessage();
    }

    public override bool IsComplete()
    {
        if (_status == true)
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
        Console.WriteLine($"[{notCompleteSymbol}] {_goalName} ({_goalDescription})");
    }



    public override string SaveGoal()
    {
        string goalLine = $"SimpleGoal~{_goalName}~{_goalDescription}~{_points}~{_status}";
        return goalLine;
    }


    public override int CalculateTotalPoint()
    {
        bool status = IsComplete();
        int tP = 0;
        if (status == true)
        {
            tP = _points;
        }
        else
        {
            tP = 0;
        }
        return tP;
    }

    public override void RecordEvent()
    {
        if (_status == false)
        {
            _status = true;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }


}