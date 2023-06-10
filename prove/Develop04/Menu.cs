class Menu
{
    //atribute for Menu class
    List<string> _option = new List<string>();

    //constructor of Menu class
    public Menu()
    {
        // read all options from Menu.txt text file to fill _option list
        string[] option = File.ReadAllLines("Menu.txt");
        foreach (string line in option)
            _option.Add($"--- {line} ---");
    }
    //method to show the menu in screen
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Unit 04 Develop: Mindfulness Program\r\n");
        Console.WriteLine("Menu options:\r\n");
        foreach (string option in _option)
        {
            Console.WriteLine(option);
        }
        Console.Write("\r\nSelect a choice from the menu: ");
    }
}