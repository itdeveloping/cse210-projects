using Develop05;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Score score = new Score();
        int selectedMainOption;
        List<string> mainMenuOptions = new();
        mainMenuOptions.Add("1. Create New Goal");
        mainMenuOptions.Add("2. List Goals");
        mainMenuOptions.Add("3. Save Goals");
        mainMenuOptions.Add("4. Load Goals");
        mainMenuOptions.Add("5. Record Event");
        mainMenuOptions.Add("6. Clear list");
        mainMenuOptions.Add("7. Quit");

        int selectedGoalOption;
        List<string> goalMenuOptions = new();
        goalMenuOptions.Add("1. Simple Goal");
        goalMenuOptions.Add("2. Eternal Goal");
        goalMenuOptions.Add("3. Checklist Goal");
        goalMenuOptions.Add("4. Main Menu");

        MainMenu mainMenu = new("Menu Options", mainMenuOptions, "Select a choice from the menu: ");
        GoalMenu goalMenu = new("The types of goals are:", goalMenuOptions, "Which type of goal you would like to create? ");
        Goal goal = null;
        FileManager fileManager = new FileManager();
        string fileName;

        List<Goal> goals = new List<Goal>();
        Console.Clear();
        if (score.GetScore() >= 1000)
            Console.WriteLine($"You are a master in accomplishing  your goals! Your actual score is: {score.GetScore()}\n");
        else
            Console.WriteLine($"Your actual score is: {score.GetScore()}\n");
        selectedMainOption = mainMenu.Show();
        while (selectedMainOption != 7)
        {

            switch (selectedMainOption) // options for Main Menu
            {
                case 1:
                    Console.Clear();

                    if (score.GetScore() >= 1000)
                        Console.WriteLine($"You are a master in accomplishing  your goals! Your actual score is: {score.GetScore()}\n");
                    else
                        Console.WriteLine($"Your actual score is: {score.GetScore()}\n");
                    selectedGoalOption = goalMenu.Show();
                    while (selectedGoalOption != 4)
                    {

                        Console.Write("What is the name of your Goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the points associated to this Goal? ");
                        int goalPoints = Int16.Parse(Console.ReadLine());

                        switch (selectedGoalOption) // options for Goal Menu
                        {
                            case 1: // create simple goal
                                goal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                                break;
                            case 2:
                                goal = new EternalGoal(goalName, goalDescription, goalPoints, false);
                                break;
                            case 3:
                                Console.Write("How many times to complete this goal? ");
                                int timesToComplete = Int16.Parse(Console.ReadLine());
                                Console.Write("How much bonus after complete this goal? ");
                                int bonusPoints = Int16.Parse(Console.ReadLine());
                                goal = new CheckListGoal(goalName, goalDescription, goalPoints, 0, timesToComplete, bonusPoints, false);
                                break;
                        }
                        goals.Add(goal);
                        Console.Write($"\nYour goal --{goalName}-- has been created. Press <enter> to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Your actual score is: {score.GetScore()} \n");
                        selectedGoalOption = goalMenu.Show();
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Your actual score is: {score.GetScore()} \n");
                    Console.WriteLine("Your goals are: \n");
                    int numeral = 0;
                    foreach (Goal myGoal in goals)
                    {
                        numeral++;
                        Console.WriteLine($"{numeral}. {myGoal.ToString()}");
                    }
                    Console.Write("\nPress <enter> to continue...");
                    Console.ReadLine();
                    break;
                case 3:

                    Console.Clear();
                    Console.Write("What is the name of the file? ");
                    fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {

                        outputFile.WriteLine(score.GetScore());

                        foreach (Goal myGoal in goals)
                        {
                            outputFile.WriteLine($"{myGoal.StringToFile()}");
                        }
                    }
                    Console.Write($"\nYour goals has been saved into --{fileName}-- file! Press <enter> to continue... ");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("What is the name of the file you have saved your goals? ");
                    fileName = Console.ReadLine();
                    goals.Clear();


                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    score.AddScore(Int16.Parse(lines[0]));

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split("|");
                        switch (parts[0])
                        {
                            case "1":
                                goal = new SimpleGoal(parts[1], parts[2], Int16.Parse(parts[3]), bool.Parse(parts[4]));

                                break;
                            case "2":
                                goal = new EternalGoal(parts[1], parts[2], Int16.Parse(parts[3]), bool.Parse(parts[4]));
                                break;
                            case "3":
                                goal = new CheckListGoal(parts[1], parts[2], Int16.Parse(parts[3]), Int16.Parse(parts[5]), Int16.Parse(parts[6]), Int16.Parse(parts[7]), bool.Parse(parts[4]));
                                break;

                        }
                        goals.Add(goal);
                    }

                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine($"Your actual score is: {score.GetScore()} \n");
                    Console.WriteLine("Your goals are: \n");

                    numeral = 0;
                    foreach (Goal myGoal in goals)
                    {
                        numeral++;
                        Console.WriteLine($"{numeral}. {myGoal.ToString()}");
                    }
                    Console.Write("\nWhich goal did you accomplished? ");
                    int goalCompleted = Int16.Parse(Console.ReadLine());
                    int earnedPoints = goals[goalCompleted - 1].RecordEvent();
                    score.AddScore(earnedPoints);
                    Console.Write($"\nCongratulations you have earned: {earnedPoints} points! Press <enter> to continue...");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Clear your goal list.");
                    Console.Write("\nAre you sure do you want to clear your goal list (y/n)? ");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        goals.Clear();
                        score.AddScore(-score.GetScore());
                        Console.WriteLine("\nYour list has been cleaned! Press <enter> to continue...");

                    }
                    else
                        Console.WriteLine("\nAction canceled! Press <enter> to continue...");
                    Console.ReadLine();

                    break;

            }
            Console.Clear();
            if (score.GetScore() >= 1000)
                Console.WriteLine($"You are a master in accomplishing  your goals! Your actual score is: {score.GetScore()}\n");
            else
                Console.WriteLine($"Your actual score is: {score.GetScore()} \n");
            selectedMainOption = mainMenu.Show();
        }

        Console.WriteLine("\nThank you for using our system. See you next time!\n");

    }

}
