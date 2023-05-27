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
        List<int> numbers = new List<int>();

        string UserInput;
        int number;

        Console.Write("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Type an integer number: ");
        UserInput = Console.ReadLine();
        number = Int32.Parse(UserInput);
        numbers.Add(number);
        while (number != 0)
        {
            Console.Write("Type an integer number: ");
            UserInput = Console.ReadLine();
            number = Int32.Parse(UserInput);
            numbers.Add(number);
        }
        Console.WriteLine("Numbers you have typed: ");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }


    }

}