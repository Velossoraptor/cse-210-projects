public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(String book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public String GetDisplayText()
    {
        //Sets the display text to "Book chapter:verse" then checks if there is an endVerse.
        //If there is an endVerse it adds "-endVerse" to the string and returns either way.
        String display = $"{_book} {_chapter}:{_verse}";
        if (_endVerse != 0)
        {
            display += $"-{_endVerse}";
        }
        return display;
    }
}