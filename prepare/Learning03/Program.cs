using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Encapsulation Learning Activity...");
        Console.WriteLine("The following is an example of a class constructor without parameters (default values 1): ");
        Fraction fraction = new Fraction();
        Console.WriteLine("Return in string: "+fraction.GetFractionString());
        Console.WriteLine("Return in decimal: "+fraction.GetDecimalValue());
        Console.WriteLine("The following is an example of a class constructor with one parameters (default bottom value 1): ");
        Fraction fraction1Param = new Fraction(5);
        Console.WriteLine("Return in string: "+fraction1Param.GetFractionString());
        Console.WriteLine("Return in decimal: "+fraction1Param.GetDecimalValue());
        Console.WriteLine("The following is an example of a class constructor with two parameters (top and bottom): ");
        Fraction fraction2Param = new Fraction(3,4);
        Console.WriteLine("Return in string: "+fraction2Param.GetFractionString());
        Console.WriteLine("Return in decimal: "+fraction2Param.GetDecimalValue());            
        Console.WriteLine("The following is an example of setter (top and bottom): ");
        fraction2Param.SetTop(1);
        fraction2Param.SetBottom(3);
        Console.WriteLine("Return in string: "+fraction2Param.GetFractionString());
        Console.WriteLine("Return in decimal: "+fraction2Param.GetDecimalValue());      
        Console.WriteLine("The following is an example of getters (top and bottom): ");
        fraction2Param.GetTop();
        fraction2Param.GetBottom();
        Console.WriteLine("End of the program.");
    }

}
