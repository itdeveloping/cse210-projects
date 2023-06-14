public class GoalMenu : Menu
{
    public GoalMenu(string filename) : base(filename)
    {
        _fileName = filename;
    }
    public override void DisplayMenu()
    {
        FillMenu();
        Console.WriteLine("-------------------------");
        Console.WriteLine("\nThe types of Goals are:");
        foreach (string option in _option)
        {
            Console.WriteLine(option);
        }
        Console.Write("\nWhich type of Goals would you like to create? ");
        _selectedOption = Console.ReadLine();

    }
}