public class Breathing : Activity
{

    public Breathing(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }
    public void ShowBreathIn(int duration)
    {
        Console.Write("\nBreathe in...");
        this.showCountdown(duration);
    }
    public void ShowBreathOut(int duration)
    {
        Console.Write("Now breathe out...");
        this.showCountdown(duration);
    }
    public void Run()
    {
        displayStartingMessage();
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        string strSeconds = Console.ReadLine();
        _duration = Int32.Parse(strSeconds);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        showSpinner(3);
        int counter = _duration;
        while (counter >= 1)
        {
            ShowBreathIn(4);
            ShowBreathOut(4);
            counter-=8;
        }
        displayEndingMessage();
    }
}