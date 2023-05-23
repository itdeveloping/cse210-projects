using System.Collections;
public class Journal
{
    public List<Entry> entryList = new List<Entry>();
    public string _filename;
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
    public void SaveFile(string fileName)
    {
        _filename = fileName;
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry element in entryList)
            {
                outputFile.WriteLine($"{element._date}|{element._prompt}|{element._answer}");
            }
        }
    }
        public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        entryList.Clear(); 
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry tempEntry = new Entry("1","1");
            tempEntry._date=parts[0];
            tempEntry._prompt=parts[1];
            tempEntry._answer=parts[2];
            entryList.Add(tempEntry);

        }
    }
}