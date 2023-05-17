public class PromptGenerator
{
    string[] _prompts = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
    int _index;
    public string DisplayPrompt()
    {
        Random _randomIndex = new Random();
        _index = _randomIndex.Next(0, 4);
        return _prompts[_index];
    }
}