public class Reference
{
   private string _book; 
   private int _chapter;
   private int _verse;
   private int _endVerse;
   private bool _thereIsEndVerse = false;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _thereIsEndVerse = true;
    }

    public string GetDisplayText()
    {
        if (_thereIsEndVerse == true)
        {
            return _book + _chapter + ": " + _verse + "-" + _endVerse; 
        }
        else
        {
            return _book + _chapter + ": " + _verse;
        }
    }
}