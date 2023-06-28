public class GoalMenu : Menu
{
    private int _selectedOption;
    public GoalMenu(string description, List<string> options, string prompt) : base(description, options, prompt)
    {
        _description = description;
        _options = options;
        _prompt = prompt;
    }
    public override int Show()
    {
        Console.WriteLine($"{_description}\n");
        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
        Console.Write($"\n{_prompt}");
        _selectedOption = Int16.Parse(Console.ReadLine());
        while (_selectedOption < 1 || _selectedOption > 6)
        {

            Console.Write($"{_selectedOption} is not a valid option! Please try again. Hit <enter> to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{_description}\n");
            foreach (string option in _options)
            {
                Console.WriteLine(option);
            }
            Console.Write($"\n{_prompt}");
            _selectedOption = Int16.Parse(Console.ReadLine());
        }
        return _selectedOption;
    }

}