public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        string[] textArray = text.Split(" ");
        foreach (String word in textArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rnd.Next(0, _words.Count());
            // Searches for an index that isnt hidden until it finds one, or the whole scripture is hidden to prevent infinite loop
            while (_words[index].IsHidden())
            {
                index = rnd.Next(0, _words.Count());
                if (IsCompletelyHidden())
                {
                    break;
                }
            }
            _words[index].Hide();
        }
    }

    public String GetDisplayText()
    {
        // Stores the reference and all the words(dependant on hidden or not state) as one string and returns it
        String reference = _reference.GetDisplayText();
        String displayText = reference + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        // loops through the list of Words and counts how many visible words there are.
        // If there are no visible words, the scripture is completely hidden, else it is visible
        int counterOfVisibleWords = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                counterOfVisibleWords++;
            }
        }
        if (counterOfVisibleWords == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}