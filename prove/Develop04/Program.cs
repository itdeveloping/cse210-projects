using System;
using System.Collections.Generic;
using System.IO;
/*
Description: Unit 04 Develop: Mindfulness Program
Author: Oscar Jose Rodriguez Alfaro
Write a program that provides the three activities described above. It should help them work through these activities in stages using basic forms of delay (animation or countdown).
*/
public class Program
{
    static void Main(string[] args)
    {
        //instantiate the Menu class
        Menu menu = new Menu();
        string userInput = "";
        int option = 0;
        while (option != 5) // loop to evaluate the option typed by the user
        {
            menu.DisplayMenu();
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Breathing breathing = new Breathing("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.Run();
                    break;
                case "2":
                    Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflection.Run();
                    break;
                case "3":
                    Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.Run();
                    break;
                case "4":
                    Gratitude gratitude = new Gratitude("Gratitude Activity", "Lists of things to be thankful for help remind us just how many good things we have in our lives. This is especially important during times where it feels like many things are going wrong.");
                    gratitude.Run();
                    break;
                case "5":
                    Console.WriteLine("\nThank you for using Mindfulness Program. See you next time!");
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.Write($"\r\nSorry, {option} is not a valid option. Hit <enter> to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}