public class Reference
{


    private string _book;
    private string _chapter;
    private string _start_Verse;
    private string _endVerse;
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _start_Verse = startVerse;
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _start_Verse = startVerse;
        _endVerse = endVerse;
    }
    public string ReferenceToString()
    {
        if (_endVerse != "")
            return _book + " " + _chapter + ":" + _start_Verse + " " + _endVerse;
        else
            return _book + " " + _chapter + ":" + _start_Verse;
    }
}