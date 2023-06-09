public class Reflection : Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _question = new List<string>();
    private Random _random = new Random();

    public Reflection(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
        _prompt.Add("--- Think of a time when you stood up for someone else. ---");
        _prompt.Add("--- Think of a time when you did something really difficult. ---");
        _prompt.Add("--- Think of a time when you helped someone in need. ---");
        _prompt.Add("--- Think of a time when you did something truly selfless. ---");

        _question.Add("Why was this experience meaningful to you? ");
        _question.Add("Have you ever done anything like this before? ");
        _question.Add("How did you get started? ");
        _question.Add("How did you feel when it was complete? ");
        _question.Add("What made this time different than other times when you were not as successful? ");
        _question.Add("What is your favorite thing about this experience? ");
        _question.Add("What could you learn from this experience that applies to other situations? ");
        _question.Add("What did you learn about yourself through this experience? ");
        _question.Add("How can you keep this experience in mind in the future? ");

    }
    public List<string> GetQuestion()
    {
        return _question;
    }
    public string GetRandomQuestion()
    {
        return "\n" + _question[_random.Next(GetQuestion().Count)];
    }
    public string GetRandomPrompt()
    {
        return "Consider the following prompt: \r\n\r\n" + _prompt[_random.Next(_prompt.Count)] + " \r\n\r\nWhen you have something in mind, press <enter> to continue...";
    }
    
    public void Run()
    {
        displayStartingMessage();

        Console.Write(GetRandomPrompt());
        Console.ReadLine();
        Console.WriteLine("\r\nNow ponder on one of the folloing questions as they related to this experience.\nYou may begin in...");
        showCountdown(5);
        Console.Clear();
        int counter = _duration;
        while (counter >= 1)
        {
            Console.Write(GetRandomQuestion());
            showSpinner(10);
            counter -= 10;
        }
        displayEndingMessage();
    }
}