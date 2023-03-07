using System;
public class Scripture
{
    private Reference _reference =new Reference();
    private List<Word> _words = new List<Word>();


    public Scripture(Word words)
    {
        _words.Add(words);
    }
        public Scripture(Reference r, Word words)
    {
        _reference = r;
        _words.Add(words);
    }



    public void HideWords()
    {
        _words[0].Hide();
    }
    public string GetRenderedText()
    {   

        return $"{_reference.GetRenderedBook()} {_reference.GetRenderedChapter()}:{_reference.GetRenderedVerse()} {_words[0].GetWords()}";
    }
    public Boolean IsCompletelyHidden()
    {
        return _words[0].IsCompletelyHidden();
    }
}