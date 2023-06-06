using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        string userInput = "";
        int option = 5;
        while (option != 4)
        {
            menu.DisplayMenu();
            userInput = Console.ReadLine();
            option = menu.SelectedOption(userInput);
            switch (option)
            {
                case 1:
                    Breathing breathing = new Breathing("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.displayStartingMessage();
                    break;
                default:
                    break;
            }

        }
    }
}