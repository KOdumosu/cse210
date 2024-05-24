public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }


    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} \n\n {_description}");
    }

    public int AskDuration()
    {
        Console.Write("\nHow long, in senconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
        return userDuration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void PauseSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime futureTime = GetFutureTime(seconds);
        int i = 0;

        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void PauseCountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        PauseSpinner(10);
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayStartMessage();
        AskDuration();
        GetReady();
    }

    public void EndActivity()
    {
        Console.WriteLine("\n\nWell done!!");
        PauseSpinner(10);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}");
        PauseSpinner(6);
    }


    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }
    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;

        return currentTime;
    }
}