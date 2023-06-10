public class Breathing : Activity
{
    //constructor of Gratitude class
    public Breathing(string activityName, string description) : base(activityName, description)
    {
        //initialize the attributes inherited from the Activity base class
        _activityName = activityName;
        _description = description;
    }

    //method for Breathe in
    public void ShowBreathIn(int duration)
    {
        Console.Write("\nBreathe in...");
        showCountdown(duration);
    }

    //method for Breathe out
    public void ShowBreathOut(int duration)
    {
        Console.Write("Now breathe out...");
        showCountdown(duration);
    }

    //Method to activate the functionality  of Breathing class
    public void Run()
    {
        displayStartingMessage();
        int counter = _duration;
        while (counter >= 1)
        {
            ShowBreathIn(5);
            ShowBreathOut(5);
            counter -= 8;
        }
        displayEndingMessage();
    }
}