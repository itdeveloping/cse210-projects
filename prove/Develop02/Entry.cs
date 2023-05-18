using System.Collections;

public class Entry
{

    public string _prompt;
    public string _answer;
    public string _date;

public Entry(string prompt,string answer )
{
    _prompt=prompt;
    _answer=answer;
    DateTime currentDateTime = DateTime.Now;
    this._date = currentDateTime.ToString(); 
}
public string DisplayString()
{
    return $"{_date} {_prompt} {_answer}";
}
}