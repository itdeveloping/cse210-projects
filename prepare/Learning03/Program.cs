using System;

class Program
{
    static void Main(string[] args)
    {
        //https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html
        /* Activity Instructions
        Practice the principle of encapsulation by creating classes to hold a fraction, such as 2/3. 
        As you recall from your Math classes, a fraction has a top number (numerator) and a bottom number (denominator). 
        The fraction can be expressed as two integers with a slash between them, such as 3/4 or as a decimal, such as 0.75. */
        Console.Clear();
        Console.WriteLine("Welcome to Encapsulation Learning Activity...");
        Console.WriteLine("The following is an example of a class constructor without parameters (default values 1): ");
        Fraction fraction = new Fraction();
        Console.WriteLine("Return in string: " + fraction.GetFractionString());
        Console.WriteLine("Return in decimal: " + fraction.GetDecimalValue());
        Console.WriteLine("The following is an example of a class constructor with one parameters (default bottom value 1): ");
        Fraction fraction1Param = new Fraction(5);
        Console.WriteLine("Return in string: " + fraction1Param.GetFractionString());
        Console.WriteLine("Return in decimal: " + fraction1Param.GetDecimalValue());
        Console.WriteLine("The following is an example of a class constructor with two parameters (top and bottom): ");
        Fraction fraction2Param = new Fraction(3, 4);
        Console.WriteLine("Return in string: " + fraction2Param.GetFractionString());
        Console.WriteLine("Return in decimal: " + fraction2Param.GetDecimalValue());
        Console.WriteLine("The following is an example of setter (top and bottom): ");
        fraction2Param.SetTop(1);
        fraction2Param.SetBottom(3);
        Console.WriteLine("Return in string: " + fraction2Param.GetFractionString());
        Console.WriteLine("Return in decimal: " + fraction2Param.GetDecimalValue());
        Console.WriteLine("The following is an example of getters (top and bottom): ");
        fraction2Param.GetTop();
        fraction2Param.GetBottom();
        Console.WriteLine("End of the program.");
        Console.Write("Hit enter to continue...");

        //Account balance program

        Console.ReadLine();
        Console.Clear();
        Account account = new Account();
        List<int> transactionsList = new List<int>();
        Console.Write("Enter the amount to deposit: ");
        string _input = Console.ReadLine();
        int Amount = Int32.Parse(_input);

        while (Amount != 0)
        {
            account.Deposit(Amount);
            Console.Write("Enter the amount to deposit: ");
            _input = Console.ReadLine();
            Amount = Int32.Parse(_input);
        }
        Console.WriteLine("Your transactions list:");
        transactionsList = account.GetTransactionsList();
        foreach (int item in transactionsList)
        {
            Console.WriteLine(item);
        }
        //Console.WriteLine(account._transactions);
        int balance = account.getBalance();
        Console.WriteLine($"You have a balance of: ${balance} in your bank account.");
        Console.WriteLine("End of the program.");
        Console.Write("Hit enter to continue...");

        //Account balance program

        Console.ReadLine();
        Console.Clear();

        //instantiate a Person class
        Person friend = new Person();
        friend.SetFirstName("Oscar");
        string FirstName = friend.GetFirstName();
        Console.WriteLine(FirstName);
        string FormalSignature = friend.GetFormalSignature();
        string InformalSignature = friend.GetInformalSignature();
        Console.WriteLine(FormalSignature);
        Console.WriteLine(InformalSignature);

        Console.WriteLine("Instantiate the class with 2 parameters");
        Person relative = new Person("Mr.", "John");
        FormalSignature = relative.GetFormalSignature();
        InformalSignature = relative.GetInformalSignature();
        Console.WriteLine($"Formal signature: {FormalSignature}");
        Console.WriteLine($"Informal signature: {InformalSignature}");

        Console.WriteLine("Instantiate the class with 3 parameters");
        Person coworker = new Person("Mrs.", "Ana", "White");
        FormalSignature = coworker.GetFormalSignature();
        InformalSignature = coworker.GetInformalSignature();
        Console.WriteLine($"Formal signature: {FormalSignature}");
        Console.WriteLine($"Informal signature: {InformalSignature}");


        Console.WriteLine("End of the program.");

    }

}
