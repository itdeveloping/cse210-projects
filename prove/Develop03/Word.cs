public class Word
{
    public List<string> _wordList = new List<string>();
    public Word()
    {

    }
    public bool getIsVisible()
    {
        return true;
    }
    public void SetIsVisible(bool isVisible)
    {

    }
    public void HideWord(int Index)
    {
        string _OneWord = _wordList[Index];


        int _wordLength = _wordList[Index].Length;
        string space = "";
        while (_wordLength >= 1)
        {
            space += " ";
            _wordLength -= 1;
        }
        _wordList[Index] = space;
    }

    public string WordToString()
    {
        string parsedWord = "";
        foreach (string item in _wordList)
        {
            parsedWord += item + " ";
        }
        return parsedWord;
    }
    public void SetWord(string word)
    {
        _wordList.Add(word);
    }
    public int ListCount()
    {
        return _wordList.Count;
    }
}