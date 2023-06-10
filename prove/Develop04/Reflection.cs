public class Reflection : Activity
{
    //attributes for the Reflection sub class 
    private List<string> _prompt = new List<string>();
    private List<string> _question = new List<string>();
    private Random _random = new Random();

    //constructor of Reflection class
    public Reflection(string activityName, string description) : base(activityName, description)
    {
        //inicialize the attributes of the class
        _activityName = activityName;
        _description = description;

        // read all prompts from ReflectionPrompts.txt text file to fill _prompt list
        string[] prompt = File.ReadAllLines("ReflectionPrompts.txt");
        foreach (string line in prompt)
            _prompt.Add($"--- {line} ---");

        // read all questions from ReflectionQuestions.txt text file to fill _question list
        string[] question = File.ReadAllLines("ReflectionQuestions.txt");
        foreach (string line in question)
            _question.Add($"> {line} ");

    }

    //Method to return the question list
    public List<string> GetQuestion()
    {
        //return the list of questions
        return _question;
    }

    //Method to get a random question from the question List and return a string
    public string GetRandomQuestion()
    {
        //return a question taken randomly from the question list
        return "\n" + _question[_random.Next(GetQuestion().Count)];
    }

    //Method to get a random prompt from the prompt List and return a string
    public string GetRandomPrompt()
    {
        //return a string with a prompt
        return "Consider the following prompt: \r\n\r\n" + _prompt[_random.Next(_prompt.Count)] + " \r\n\r\nWhen you have something in mind, press <enter> to continue...";
    }

    //Method to activate the functionality  of Reflection class
    public void Run()
    {
        displayStartingMessage();
        Console.Write(GetRandomPrompt());
        Console.ReadLine();
        Console.WriteLine("\r\nNow ponder on one of the following questions as they related to this experience.\nYou may begin in...");
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