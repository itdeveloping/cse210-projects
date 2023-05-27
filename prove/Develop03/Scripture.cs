public class Scripture
{
    private int _wordListCount;
    private int _random;
    private int _counter;
    private Reference _reference;
    private List<string> _verse = new List<string>();
    private int _wordsToHide;
    public Scripture(Reference reference, Word word, int WordsToHide)
    {
        _reference = reference;
        _verse = word._wordList;
        _wordsToHide = WordsToHide;
    }
    public bool IsFinish(Word word)
    {

        _counter = 0;
        foreach (string item in word._wordList)
        {
            if (item.Trim() != "") _counter += 1;
        }
        if (_counter != 0)
        {
            SetVisibility(word);
            return false;
        }
        else
            return true;
    }
    public string ParseScripture()
    {

        string parsedScripture = _reference.ReferenceToString() + " ";
        foreach (string item in _verse)
        {
            parsedScripture += item + " ";
        }
        return parsedScripture;
    }
    private void SetVisibility(Word word)
    {
        _wordListCount = word.ListCount();
        _counter = _wordsToHide;

        while (_counter >= 1)
        {
            Random rnd = new Random();
            _random = rnd.Next(0, _wordListCount);
            while (word.getIsVisible(_random))
            {
                word.HideWord(_random);
                _counter -= 1;
            }
            // Console.WriteLine(_random);
        }
    }
}