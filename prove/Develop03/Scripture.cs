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
        int _counter = _wordsToHide;
        int _found = 0;
        int _ranInt;
        while (_counter >= 1)
        {
            _found = 0;
            while (_found == 0)
            {
                //Console.WriteLine(_random.Next(0, verse.Count));
                _ranInt = _random.Next(0, verse.Count);
                if (verse[_ranInt].getIsVisible() == true)
                {
                    verse[_ranInt].SetIsVisible(false);
                    _found = 1;
                    _counter -= 1;
                }
            }
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
    public string ScriptureToString()
    {
        //calls the SetVisibility function to randomly hide a word

        if (IsFinish() == false)
            SetVisibility();
        //create a string variable to add reference and verse in order to output the whole scripture
        string _string = _reference.ReferenceToString() + " ";

        foreach (Word word in verse)
        {
            if (word.getIsVisible() == true)
                _string += word.WordToString() + " ";
            else
            {
                int _counter = word.WordToString().Length;
                while (_counter >= 1)
                {
                    _string += " ";
                    _counter -= 1;
                }
                _string += " ";
            }

        }

        return _string;
    }
    public string ScriptToString()
    {
        //create a string variable to add reference and verse in order to output the whole scripture
        string _string = _reference.ReferenceToString() + " ";

        foreach (Word word in verse)
        {
            if (word.getIsVisible() == true)
                _string += word.WordToString() + " ";
            else
            {
                int _counter = word.WordToString().Length;
                while (_counter >= 1)
                {
                    _string += " ";
                    _counter -= 1;
                }
                _string += " ";

            }

        }

        return _string;
    }

}