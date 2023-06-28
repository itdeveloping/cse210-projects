public abstract class Menu
{
    protected string _description;
    protected List<string> _options = new List<string>();
    protected string _prompt;
    public Menu(string description, List<string> options, string prompt)
    {

    }
    public Menu( List<string> options)
    {

    }
    public abstract int Show();

}