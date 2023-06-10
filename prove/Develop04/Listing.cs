public class Listing : Activity
{
    //attributes for Listing class
    private List<string> _prompt = new List<string>();
    private Random _random = new Random();

    //constructor of Listing class
    public Listing(string activityName, string description) : base(activityName, description)
    {
        //inicialize the attributes of the class
        _activityName = activityName;
        _description = description;

        // read all prompts from Listing.txt text file to fill _prompt list
        string[] listing = File.ReadAllLines("Listing.txt");
        foreach (string line in listing)
            _prompt.Add($"--- {line} ---");
    }
    //Method to get a random prompt from the prompt List and return a string
    public string GetRandomPrompt()
    {
        return "\r\n" + _prompt[_random.Next(_prompt.Count)] + "\r\n\r\nYou may begin in...";
    }
    //Method to activate the functionality  of Listing class
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