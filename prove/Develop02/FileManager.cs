using System.Collections;

public class FileManager
{
    string _fileName;
    public ArrayList EntryArray = new ArrayList();
    public void SaveFile(string fileName, ArrayList entryArray)
    {
        this._fileName = fileName;
        using (StreamWriter outputFile = new StreamWriter(this._fileName))
        {
            foreach (object element in entryArray)
            {
                outputFile.WriteLine(element);
            }
        }
    }
    public ArrayList ReadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            EntryArray.Add(parts[0] + "|" + parts[1] + "|" + parts[2]);

        }
        return EntryArray;
    }

}