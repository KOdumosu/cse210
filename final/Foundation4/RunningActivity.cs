public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime dateTime, int duration, double distance) : base(dateTime, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}