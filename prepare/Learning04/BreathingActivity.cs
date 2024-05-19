public class BreathingActivity: Activity
{
    private string _message1;
    private string _message2;

    public BreathingActivity(string activityName, string description, int duration, string message1, string message2):base(activityName, description, duration)
    {
        _message1 = message1;
        _message2 = message2;
    }

    public void Breathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        Console.Write($"\n\n{_message1}");
        PauseCountdownTimer(2);
        Console.Write($"\n{_message2}");
        PauseCountdownTimer(3);

        while(currentTime <= futureTime)
        {
            Console.Write($"\n\n{_message1}");
            PauseCountdownTimer(4);
            Console.Write($"\n{_message2}");
            PauseCountdownTimer(6);

            currentTime = DateTime.Now;
        }
    }
}