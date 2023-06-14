public class Menu
{
    protected List<string> _option = new List<string>();
    protected string _fileName;
    protected string _selectedOption;
    public Menu(string filename)
    {
        _fileName = filename;
    }
    protected void FillMenu()
    {
        // read all options from MainMenu.txt text file to fill _option list
        string[] option = File.ReadAllLines(_fileName);
        _option.Clear();
        foreach (string line in option)
            _option.Add($"{line}");
    }
    public virtual void DisplayMenu()
    {
        FillMenu();
        Console.WriteLine("\nMenu Options:");
        foreach (string option in _option)
        {
            Console.WriteLine(option);
        }
        Console.Write("\nSelect a choice from the menu: ");
        _selectedOption = Console.ReadLine();
    }
}