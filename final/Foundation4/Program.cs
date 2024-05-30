
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity(new DateTime(2023, 12, 04), 30, 15.0);
        _activities.Add(runningActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2023, 12, 04), 30, 3.0);
        _activities.Add(swimmingActivity);

        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2023, 12, 04), 30, 10);
        _activities.Add(cyclingActivity);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
