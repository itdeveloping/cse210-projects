using System;

class Program
{
    static void Main(string[] args)
    {
        /*A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60*/
        Console.Write("Type your grade percentage: ");
        string Number = Console.ReadLine();
        string LastCharacter = Number.Substring(1);
        int Digit = int.Parse(LastCharacter);
        string Sign="";


        int Percentage = int.Parse(Number);
        string grade = "";
        string message = "Congratulations! you passed!";
        if (Percentage >= 90)
        {
            grade = "A";
            if (Digit<3){
                Sign="-";
            }

        }
        else if (Percentage >= 80)
        {
            grade = "B";
            if (Digit<3){
                Sign="-";
            } else if (Digit>=7) {
                Sign="+";
            }
        }
        else if (Percentage >= 70)
        {
            grade = "C";
            if (Digit<3){
                Sign="-";
            } else if (Digit>=7) {
                Sign="+";
            }            
        }
        else if (Percentage >= 60)
        {
            message = "We are sorry, you did not pass but keep going you can do it the next time!";
            grade = "D";
            if (Digit<3){
                Sign="-";
            } else if (Digit>=7) {
                Sign="+";
            }            
        }
        else
        {
            grade = "F";
        }
            

        Console.WriteLine($"Your grade is: {Sign} {grade}");
        Console.WriteLine($"{message}");
        //Console.WriteLine($"{digit}");
    }

}