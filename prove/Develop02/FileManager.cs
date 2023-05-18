using System.Collections;

public class FileManager
{
    string _fileName;
    public ArrayList _entryArray = new ArrayList();
    public void SaveFile(string fileName)
    {
        _fileName = fileName;
        using (StreamWriter outputFile = new StreamWriter(this._fileName))
        {
            foreach (Entry element in _entryArray)
            {
                outputFile.WriteLine(element);
            }
        }
    }
    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            _entryArray.Add(parts[0] + "|" + parts[1] + "|" + parts[2]);

        }
    }

}