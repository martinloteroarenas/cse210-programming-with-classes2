public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _numberOfNotHiddenWords;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");

        foreach(string eachWord in words)
        {
            Word word = new Word(eachWord);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        _numberOfNotHiddenWords = NumberOfNotHiddenWords();
        if (_numberOfNotHiddenWords == 2 && numberToHide == 3)
        {
            for (int i = 1; i < numberToHide; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count);
                while(_words[randomIndex].IsHidden() == true)
                {
                    randomIndex = random.Next(0, _words.Count);
                }
                _words[randomIndex].Hide();
            }
        }
        else if(_numberOfNotHiddenWords == 1 && numberToHide == 3)
        {
            numberToHide = numberToHide - 1;
            for (int i = 1; i < numberToHide; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count);
                while(_words[randomIndex].IsHidden() == true)
                {
                    randomIndex = random.Next(0, _words.Count);
                }
                _words[randomIndex].Hide();
            }
        }
        else if(_numberOfNotHiddenWords == 1 && numberToHide == 2)
        {
            for (int i = 1; i < numberToHide; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count);
                while(_words[randomIndex].IsHidden() == true)
                {
                    randomIndex = random.Next(0, _words.Count);
                }
                _words[randomIndex].Hide();
            }
        }
        else
        {
            numberToHide = numberToHide + 1;
            for (int i = 1; i < numberToHide; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, _words.Count);
                while(_words[randomIndex].IsHidden() == true)
                {
                    randomIndex = random.Next(0, _words.Count);
                }
                _words[randomIndex].Hide();
            }
        }
    }
    public string GetDisplayText()
    {   
        string display = ""; 
        foreach (Word word in _words)
        {
            display = display + word.GetDisplayText() + "  ";
        }
        return display;
    }
    public bool IsCompletelyHidden()
    {
        bool completelyHidden = true;
        foreach (Word word in _words)
        {      
            if (word.IsHidden() == false)
            {
                completelyHidden = false;
                return completelyHidden;
            }
        }
        return completelyHidden;
    }

    public int NumberOfNotHiddenWords()
    {
        int notHiddenWords = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                notHiddenWords = notHiddenWords + 1;
            }
        }
        return notHiddenWords;
    }
}