public class Gratitude : Activity
{
    //attributes for the Gratitude sub class 
    List<string> _prompt = new List<string>();
    private Random _random = new Random();

    //constructor of Gratitude class
    public Gratitude(string activityName, string description) : base(activityName, description)
    {
        //inicialize the attributes of the class
        _activityName = activityName;
        _description = description;

        // read all prompt from GratitudeList.txt text file to fill _prompt list
        string[] gratitude = File.ReadAllLines("GratitudeList.txt");
        foreach (string line in gratitude)
            _prompt.Add($"--- {line} ---");
    }

    //Method that return a random prompt from the prompt list
    public string GetRandomPrompt()
    {
        return "\r\n\r\n" + _prompt[_random.Next(_prompt.Count)] + " \r\n\r\nWhen you have something in mind, press <enter> to continue...";
    }

    //Method to activate the functionality  of Gratitude class
    public void Run()
    {
        displayStartingMessage();
        Console.WriteLine("Type about gratitude of the following prompt:");
        Console.Write(GetRandomPrompt());
        Console.ReadLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
        }

        displayEndingMessage();

    }

}