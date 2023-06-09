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
                    breathing.Run();
                    break;
                case 2:
                    Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflection.Run();
                    break;
                case 3:
                    Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.Run();
                    break;
                default:
                    break;
            }

        }
    }
}