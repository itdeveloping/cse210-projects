using System.Collections;
public class Journal
{
    public ArrayList entryList = new ArrayList();

    public void JournalDisplay(ArrayList entryList)
    {
        foreach (string i in entryList)
        {
            Console.WriteLine("{0} ", i);
        }

    }

}