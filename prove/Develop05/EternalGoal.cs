public class EternalGoal : Goal
{
    protected int _counter = 0;
    public EternalGoal()
    {

    }
    public EternalGoal(string goalName, string goalDescription, int points) : base(goalName, goalDescription, points)
    {

    }

    public override void DisplayStartMessage()
    {
        CreateStartMessage();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void ListGoal(int i)
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }

    public override string SaveGoal()
    {
        string goalLine = $"EternalGoal~{_goalName}~{_goalDescription}~{_points}";
        return goalLine;
    }

    public override int CalculateTotalPoint()
    {
        int points = _points;
        return points;
    }

    public override void RecordEvent()
    {
        _counter++;
    }




}