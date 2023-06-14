using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Unit 05 Develop: Eternal Quest Program\n");
        Menu menu = new Menu("MainMenu.txt");
        menu.DisplayMenu();
        GoalMenu goalMenu = new GoalMenu("GoalMenu.txt");
        goalMenu.DisplayMenu();
    }
}