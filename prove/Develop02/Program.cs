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
        int Option;
        FileManager _fileManager = new FileManager();
        Journal journal = new Journal();

        PromptGenerator _promptGenerator = new PromptGenerator();

        //display menu option
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        Option = Convert.ToInt32(Console.ReadLine());
        while (Option != 5)
        {
            switch (Option)
            {
                case 1: //1. Write
                    prompt = _promptGenerator.DisplayPrompt();
                    Console.WriteLine(prompt);
                    answer = Console.ReadLine();
                    Entry entry = new Entry(prompt, answer);
                    journal.AddEntry(entry);
                    break;
                case 2: //2. Display
                    Console.WriteLine("Entries you typed: ");
                    journal.JournalDisplay();
                    break;
                case 3: //3. Load
                    Console.WriteLine("Enter the file name you want to load: ");
                    fileName = Console.ReadLine();
                    _fileManager.LoadFile(fileName);
                    break;
                case 4: //4. Save
                    Console.WriteLine("Enter the file name for your journal: ");
                    fileName = Console.ReadLine();
                    _fileManager.SaveFile(fileName);
                    break;
                case 5: //5. Quit
                    Console.WriteLine("Thank you for using our systems!");
                    break;
                default:
                    Console.WriteLine("----------------------This is not a valid option.");
                    break;
            }
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Option = Convert.ToInt32(Console.ReadLine());
        }

        /*
        DateTime currentDateTime = DateTime.Now;
        Entry entry = new Entry();
        entry._prompt = "Where are you?";
        entry._answer = "Hello world from a class";
        entry._date = currentDateTime;
        entry.DisplayEntry();*/
    }

}


