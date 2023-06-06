public class Breathing : Activity
{
    List<string> _messageIn = new List<string>();
    List<string> _messageOut = new List<string>();

    public Breathing(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }
}