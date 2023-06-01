using System;

class Program
{
    static void Main(string[] args)
    {
        //Inheritance Learning Activity

        Console.Clear();
        //super class
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine("Super class: Assignment");
        Console.WriteLine(assignment1.GetSummary());
        //subclass
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine("\nSubclass: MathAssignment");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        //subclass
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine("\nSubclass: MathAssignment");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());



    }
}