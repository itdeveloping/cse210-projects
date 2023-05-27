public class Word
{
    private bool _isVisible;
    private string _word;
    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }
    public bool getIsVisible()
    {
        if (_isVisible == true)
            return true;
        else
            return false;
    }
    public void SetIsVisible(bool isVisible)
    {
        _isVisible = isVisible;
    }

    public string WordToString()
    {
        if (getIsVisible())
            return _word;
        else
            return new String('_', _word.Length);        
    }

}