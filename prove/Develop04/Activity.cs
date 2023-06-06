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
        Console.WriteLine($"Welcome to {_activityName}");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        Console.ReadLine();
    }
    public void displayEndingMessage()
    {

    }

    public void GetDuration(int duration)
    {

    }

    public void showSpinner()
    {
    }
    public void showCountdown()
    {

    }

}