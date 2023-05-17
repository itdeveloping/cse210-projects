/*
Student name: Oscar Jose Rodriguez Alfaro
*/

using System;
using System.IO;
using System.Collections;
class Program
{

    static void Main(string[] args)
    {
        string prompt;
        string answer;
        string fileName;
        FileManager fileManager = new FileManager();
        Journal journal = new Journal();

        //create an instance for the menu
        Program p = new Program();
        Entry entry = new Entry();

        //display menu option
        int Option = p.Menu();
        
        while (Option != 5)
        {
            switch (Option)
            {
                case 1: //1. Write
                    PromptGenerator _promptGenerator = new PromptGenerator();
                    prompt = _promptGenerator.DisplayPrompt();
                    Console.WriteLine(prompt);
                    answer = Console.ReadLine();
                    entry.Writing(prompt, answer);
                    break;
                case 2: //2. Display
                    Console.WriteLine("Entries you typed: ");
                    journal.JournalDisplay(entry.EntryArray);
                    break;
                case 3: //3. Load
                    Console.WriteLine("Enter the file name you want to load: ");
                    fileName = Console.ReadLine();
                    entry.EntryArray = fileManager.ReadFile(fileName);
                    break;
                case 4: //4. Save
                    Console.WriteLine("Enter the file name for your journal: ");
                    fileName = Console.ReadLine();
                    fileManager.SaveFile(fileName, entry.EntryArray);
                    break;
                case 5: //5. Quit
                    Console.WriteLine("Thank you for using our systems!");
                    break;
                default:
                    Console.WriteLine("----------------------This is not a valid option.");
                    break;
            }
            Option = p.Menu();
        }

        /*
        DateTime currentDateTime = DateTime.Now;
        Entry entry = new Entry();
        entry._prompt = "Where are you?";
        entry._answer = "Hello world from a class";
        entry._date = currentDateTime;
        entry.DisplayEntry();*/
    }
    public int Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int Option = Convert.ToInt32(Console.ReadLine());
        return Option;
    }
}


