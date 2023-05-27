public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
    public Person () {
        _title="Mr.";
        _firstName="Anonymous";
        _lastName="Unkown";
    }
        public Person (string Title, string FirstName)
    {
        _title=Title;
        _firstName=FirstName;
        
    }
        public Person (string Title, string FirstName, string LastName)
    {
        _title=Title;
        _firstName=FirstName;
        _lastName=LastName;
        
    }
    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }
    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }
    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName=firstName;
    }
    public string GetFirstName(){
        return _firstName;
    }
}