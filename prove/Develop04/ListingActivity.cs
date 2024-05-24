public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    private List<string> _userList = new List<string>();

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void Listing()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in...");
        PauseCountdownTimer(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write("> ");
            _userList.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        int listCount = _userList.Count;
        Console.WriteLine($"You listed {listCount} items!");

    }
}