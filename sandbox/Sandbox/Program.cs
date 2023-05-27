using System;

class Program
{
    static void Main(string[] args)
    {
        Student estudiante = new Student("987654","Oscar Jose");
        string name = estudiante.GetName();
        string Id = estudiante.GetId();
        Console.WriteLine(name);
        Console.WriteLine(Id);

    }
}