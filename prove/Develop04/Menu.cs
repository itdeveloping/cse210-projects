class Menu {
    List<string> _option = new List<string>();
    public Menu ()
    {
        _option.Add("1.- Start Breathing Activity");
        _option.Add("2.- Start Reflection Activity");
        _option.Add("3.- Start Listing Activity");
        _option.Add("4.- Quit");
    }
    public void DisplayMenu(){
        Console.Clear();
        Console.WriteLine("Menu options:");
        foreach (string option in _option)
        {
            Console.WriteLine(option);
        }
        Console.Write("Select a choince from the menu: ");
    }
    public int SelectedOption(string option)
    {
        return Int32.Parse(option);
    }
}