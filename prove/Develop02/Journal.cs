using System.Collections;
public class Journal
{
    public string _prompt;
    public string _answer;
    public DateTime _date;
    public ArrayList EntryArray = new ArrayList();
    public void JournalDisplay()
    {
        foreach (string i in EntryArray)
        {
            Console.WriteLine("{0} ", i);
        }

    }
    public void JournalWriting(string prompt, string answer)
    {
        DateTime currentDateTime = DateTime.Now;
        this._date = currentDateTime;
        this._prompt = prompt;
        this._answer = answer;

        EntryArray.Add(this._date + "|" + this._prompt + "|" + this._answer);
        //Console.WriteLine(this._prompt);
        //Console.WriteLine(this._answer);
        //Console.WriteLine(this._date);
    }
}