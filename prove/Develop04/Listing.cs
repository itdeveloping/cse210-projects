public class Listing : Activity
{
    private List<string> _prompt = new List<string>();
    private Random _random = new Random();

    public Listing(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
        _prompt.Add("--- Who are people that you appreciate? --- ");
        _prompt.Add("--- What are personal strengths of yours? --- ");
        _prompt.Add("--- Who are people that you have helped this week? --- ");
        _prompt.Add("--- When have you felt the Holy Ghost this month? --- ");
        _prompt.Add("--- Who are some of your personal heroes? --- ");

    }
    public string GetRandomPrompt()
    {
        return "\r\n" + _prompt[_random.Next(_prompt.Count)] + "\r\n\r\nYou may begin in...";
    }
    public void Run()
    {
        displayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.Write(GetRandomPrompt());
        showCountdown(5);
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write(">");
                Console.ReadLine();
            }

        displayEndingMessage();
    }
}