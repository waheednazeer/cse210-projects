using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference()
    {

    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
        public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetRenderedBook()
    {
        return _book;
    }
    public int GetRenderedChapter()
    {
        return _chapter;
          
    }
    public int GetRenderedVerse()
    {
        return _verse;
        
    }

        public int GetEndVerse()
    {
        return _endVerse;
        
    }
}