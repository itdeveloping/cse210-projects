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
        Program p = new Program();
        int Option = p.Menu();
        while (Option != 5)
        {
            switch (Option)
            {
                case 1:
                    PromptGenerator _promptGenerator = new PromptGenerator();
                    prompt = _promptGenerator.DisplayPrompt();
                    Console.WriteLine(prompt);
                    answer = Console.ReadLine();
                    journal.JournalWriting(prompt, answer);

                    break;
                case 2:
                    Console.WriteLine("Entries you typed: ");
                    journal.JournalDisplay();
                    break;
                case 3:
                    Console.WriteLine("Enter the file name you want to load: ");
                    fileName = Console.ReadLine();
                    journal.EntryArray = fileManager.ReadFile(fileName);
                    break;
                case 4:
                    Console.WriteLine("Enter the file name for your journal: ");
                    fileName = Console.ReadLine();
                    fileManager.SaveFile(fileName, journal.EntryArray);
                    break;
                case 5:
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
public class Journal
{
    public string _prompt;
    public string _answer;
    public DateTime _date;
    public ArrayList EntryArray = new ArrayList();
    public void JournalDisplay()
    {
        foreach (string i in EntryArray)
        {
            Console.WriteLine("{0} ", i);
        }

    }
    public void JournalWriting(string prompt, string answer)
    {
        DateTime currentDateTime = DateTime.Now;
        this._date = currentDateTime;
        this._prompt = prompt;
        this._answer = answer;

        EntryArray.Add(this._date + "|" + this._prompt + "|" + this._answer);
        //Console.WriteLine(this._prompt);
        //Console.WriteLine(this._answer);
        //Console.WriteLine(this._date);
    }
}
public class PromptGenerator
{
    string[] _prompts = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
    int _index;
    public string DisplayPrompt()
    {
        Random _randomIndex = new Random();
        _index = _randomIndex.Next(0, 4);
        return _prompts[_index];
    }
}
public class FileManager
{
    string _fileName;
    public ArrayList EntryArray = new ArrayList();
    public void SaveFile(string fileName, ArrayList entryArray)
    {
        this._fileName = fileName;
        using (StreamWriter outputFile = new StreamWriter(this._fileName))
        {
            foreach (object element in entryArray)
            {
                outputFile.WriteLine(element);
            }
        }
    }
    public ArrayList ReadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            EntryArray.Add(parts[0] + "|" + parts[1] + "|" + parts[2]);

        }
        return EntryArray;
    }

}