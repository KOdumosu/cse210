public class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected bool _status;

    public Goal()
    {
        _goalName = " ";
        _goalDescription = " ";
        _points = 0;
        _status = false;
    }

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }


    public void CreateStartMessage()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        _points = int.Parse(points);


        _status = false;
    }

    public virtual void DisplayStartMessage()
    {

    }
    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void ListGoal(int i)
    {

    }

    public virtual string SaveGoal()
    {
        string goalLine = "";
        return goalLine;
    }

    public virtual int CalculateTotalPoint()
    {
        return 0;
    }

    public virtual void RecordEvent()
    {

    }

}