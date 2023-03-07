public class Word
{
    public string _text;
    private List <string> _textList;
    private Boolean _isHidden;
   



    public Word(string text)
    {
        _text= text;
        _textList= new List<string>(_text.Split(' '));
    }


    public void Hide()
    {
        Random random = new Random();
        string a= "_";
        string b="_";
        int index = random.Next(0,_textList.Count);
        //Console.WriteLine(_textList[index]);
        for (int i = 0; i < _textList[index].Length; i++)
        {
        
            if (i > 0)
            {
            a= a+b;
            }      

        }
        _textList[index] = a;
        

    }


    public Boolean IsCompletelyHidden()
    {
         _isHidden= true;      

        for (int i = 0; i < _textList.Count; i++)
        {
            foreach (var item in _textList[i])
            {
                if(item != '_')
                {
                    _isHidden= false;
               
                }
            }
        }
        return _isHidden;
    }

public string GetWords()
{
    string my= string.Join(' ', _textList);
    return my;
}


}