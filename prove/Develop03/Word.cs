public class Word
{
    private String _text;
    private bool _isHidden;

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        // Sets the text to hidden
        _isHidden = true;
    }

    public void Show()
    {
        // Sets the text to visible
        _isHidden = false;
    }

    public bool IsHidden()
    {
        // Returns whether or not the text is hidden
        return _isHidden;
    }
    public String GetDisplayText()
    {
        // Checks if the word is hidden. if it is > create a string with underscores and return that.
        // Else return the normal text.
        if (IsHidden())
        {
            int count = _text.Count();
            String hiddenWord = "";

            for (int i = 0; i < count; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}