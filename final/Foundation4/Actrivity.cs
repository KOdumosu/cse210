public class Activity
{
    private DateTime _dateTime;
    protected int _duration;

    public Activity(DateTime dateTime, int duration)
    {
        _dateTime = dateTime;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_dateTime.ToShortDateString()} {GetType().Name} ({_duration} min)";
    }
}