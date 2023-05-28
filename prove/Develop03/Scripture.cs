public class Scripture
{
    private Random _random = new Random();

    private Reference _reference;
    private List<Word> verse = new List<Word>();
    private int _wordsToHide;

    public bool IsFinish()
    {
        int _finish = 0;
        foreach (Word word in verse)
        {
            if (word.getIsVisible() == true)
                _finish += 1;
        }
        if (_finish == 0)
            return true;
        else
            return false;
    }
    public Scripture(string scripture, Reference reference, int WordsToHide)
    {
        _reference = reference;
        _wordsToHide = WordsToHide;
        ParseScripture(scripture);
    }
    private void SetVisibility()
    {
        int outerCounter = _wordsToHide;
        bool found;
        int randomNumber;
        while (outerCounter >= 1)
        {
            found = false;
            while (!found)
            {
                int innerCounter = 1;
                while (innerCounter <= verse.Count)
                {
                    randomNumber = _random.Next(verse.Count);
                    if (verse[randomNumber].getIsVisible() == true)
                    {
                        verse[randomNumber].SetIsVisible(false);
                        found = true;
                        innerCounter = verse.Count + 1;
                    }
                    else innerCounter += 1;
                    if (innerCounter > verse.Count && !found) found = true;
                    if (innerCounter > verse.Count) found = true;
                }
            }
            outerCounter -= 1;
        }
    }
    private void ParseScripture(string scripture)
    {
        List<string> wordList = scripture.Split(' ').ToList();

        foreach (string item in wordList)
        {
            Word word = new Word(item);
            verse.Add(word);
        }
    }
    public string ScriptureToString(bool begin)
    {
        //calls the SetVisibility function to randomly hide a word
        if (!begin) SetVisibility();
        string _string = "";
        //create a string variable to add reference and verse in order to output the whole scripture
        _string = _reference.ReferenceToString() + " ";
        foreach (Word word in verse)
        {
            _string += word.WordToString() + " ";
        }
        return _string;
    }
}