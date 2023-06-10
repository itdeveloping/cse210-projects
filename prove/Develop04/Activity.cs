public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void displayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        string strSeconds = Console.ReadLine();
        _duration = Int32.Parse(strSeconds);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        showSpinner(5);
    }
    public void displayEndingMessage()
    {
        Console.WriteLine("\nWell done...");
        showSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_activityName}");
        showSpinner(4);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void showSpinner(int seconds)
    {
        while (seconds >= 1)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            seconds -= 1;
        }
        Console.WriteLine();
    }
    public void showCountdown(int seconds)
    {
        while (seconds >= 1)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds -= 1;
        }
        Console.WriteLine();
    }

}