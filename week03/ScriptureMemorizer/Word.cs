public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        string textHidden = "";
         for (int i = 0; i<_text.Length; i++)
        {
            textHidden = textHidden + "_ ";
        }
        _text = textHidden;
        _isHidden = true;
    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        return _isHidden;   
    }
    public string GetDisplayText()
    {
        return _text;
    }
}