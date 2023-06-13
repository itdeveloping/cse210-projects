public class Animal
{
    protected string _name;
    protected string _sound;
    public Animal(string name)
    {
        _name = name;
        _sound = "generic";
    }
    public Animal(string name, string sound)
    {
        _name = name;
        _sound = sound;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} makes a {_sound} voice");
    }

}
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        _name = name;
    }
    public Dog(string name, string sound) : base(name, sound)
    {
        _name = name;
        _sound = sound;
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} makes a {_sound} voice");
    }
}
public class Donkey : Animal
{
    public Donkey(string name) : base(name)
    {
        _name = name;
    }
    public Donkey(string name, string sound) : base(name, sound)
    {
        _name = name;
        _sound = sound;
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} makes a {_sound} voice");
    }
}