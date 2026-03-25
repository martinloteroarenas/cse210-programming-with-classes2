using System.Dynamic;

public class Comment
{
    private string _person;
    private string _text;
    public Comment(string text, string person)
    {
        _person = person;
        _text = text;
    }
    public string GetDisplayText()
    {
        return "@" + _person + ": " + _text;
    }
}