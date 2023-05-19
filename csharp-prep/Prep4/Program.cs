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

        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        UserInput=Console.ReadLine();
        number = Int32.Parse(UserInput);
        numbers.Add(number);
        Console.WriteLine(numbers[0]);

    }

}