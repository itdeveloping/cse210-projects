using System.Collections;
public class Journal
{
    public List<Entry> entryList = new List<Entry>();

    public void JournalDisplay()
    {
        foreach (Entry i in entryList)
        {
            Console.WriteLine(i.DisplayString());
        }

    }
    public void AddEntry(Entry entry)
    {
        entryList.Add(entry);
    }

}