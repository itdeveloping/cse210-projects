class Student : Person
{
    private string _Id;

    public Student(string Id, string name) : base (name)
    {
        //_Id=Id;
        _Id = base.GetName();
        Console.WriteLine($"Student Number: {_Id}");
    }
    public string GetId()
    {
        
        return _Id;
    }
}