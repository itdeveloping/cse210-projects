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
        showCountdown(duration);
    }
    public void ShowBreathOut(int duration)
    {
        Console.Write("Now breathe out...");
        showCountdown(duration);
    }
    public void Run()
    {
        displayStartingMessage();
        int counter = _duration;
        while (counter >= 1)
        {
            ShowBreathIn(5);
            ShowBreathOut(5);
            counter-=8;
        }
        displayEndingMessage();
    }
}