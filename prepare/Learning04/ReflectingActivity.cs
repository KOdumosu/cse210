public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string activityName, string description, int duration):base(activityName, description, duration)
    {

    }
    
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public void Reflecting()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter )
        {
            Console.WriteLine("\nNow ponder on each of the following questions as they related to the experience.");
            Console.Write("You may begin in...");
            PauseCountdownTimer(5);
            Console.Clear();
        }

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question}{" "}");
            PauseSpinner(20);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }

}