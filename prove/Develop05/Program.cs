using Develop05;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int selectedMainOption;
        List<string> mainMenuOptions = new();
        mainMenuOptions.Add("1. Create New Goal");
        mainMenuOptions.Add("2. List Goals");
        mainMenuOptions.Add("3. Save Goals");
        mainMenuOptions.Add("4. Load Goals");
        mainMenuOptions.Add("5. Record Event");
        mainMenuOptions.Add("6. Quit");

        int selectedGoalOption;
        List<string> goalMenuOptions = new();
        goalMenuOptions.Add("1. Simple Goal");
        goalMenuOptions.Add("2. Eternal Goal");
        goalMenuOptions.Add("3. Checklist Goal");
        goalMenuOptions.Add("4. Main Menu");

        MainMenu mainMenu = new("Menu Options", mainMenuOptions, "Select a choice from the menu: ");
        GoalMenu goalMenu = new("The types of goals are:", goalMenuOptions, "Which type of goals you would like to create? ");

        selectedMainOption = mainMenu.Show();
        while (selectedMainOption != 6)
        {
            switch (selectedMainOption) // options for Main Menu
            {
                case 1:
                    selectedGoalOption = goalMenu.Show();
                    while (selectedGoalOption != 4)
                    {
                        switch (selectedGoalOption) // options for Goal Menu
                        {
                            case 1: // create simple goal
                                Console.Write("What is the name of your Goal? ");
                                string goalName = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string goalDescription = Console.ReadLine();
                                Console.Write("What is the pints associated to this Goal? ");
                                int goalPoints = Int16.Parse(Console.ReadLine());
                                SimpleGoal simpleGoal = new(goalName, goalDescription, goalPoints);

                                Console.Write($"Your goal {goalName} has been created. Press <enter> to continue...");
                                Console.ReadLine();
                                selectedGoalOption = goalMenu.Show();
                                break;
                            case 2:
                                Console.WriteLine(selectedGoalOption);

                                break;
                            case 3:
                                Console.WriteLine(selectedGoalOption);

                                break;
                            case 4:
                                break;

                        }
                        
                    }
                    break;
                case 2:
                    Console.WriteLine(selectedMainOption);
                    break;
                case 3:
                    Console.WriteLine(selectedMainOption);
                    break;
                case 4:
                    Console.WriteLine(selectedMainOption);
                    break;
                case 5:
                    Console.WriteLine(selectedMainOption);
                    break;
                case 6:

                    Console.WriteLine("Thank you for using our system. See you next time!");
                    System.Environment.Exit(0);

                    break;
            }
            selectedMainOption = mainMenu.Show();
        }

    }
}