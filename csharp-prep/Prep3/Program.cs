using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._givenName = "Oscar";
        person._familyName = "Rodriguez";
        person.ShowWesternName();
        person.ShowEasternName();
        person._givenName = "Mercedes";
        person._familyName = "Ramirez";
        person.ShowEasternName();
        person.ShowWesternName();

        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";
        Console.WriteLine($"The blind for this kitchen is: {kitchen._color}");
        double materialAmount = kitchen.GetArea();
        Console.WriteLine($"The total material to use is: {materialAmount} sq.in.");
    }

    public class Person
    {
        public string _givenName = "";
        public string _familyName = "";

        public Person()
        {

        }
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
    public class Blind
    {
        public float _width;
        public float _height;
        public string _color;
        public double GetArea()
        {
            return _width * _height;
        }

    }
}