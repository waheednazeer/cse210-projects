public class Entry
{
    
    public List<string> _entryList= new List<string>();
    public string _userEntry="";
    


    public void Display()
    {
    for (int i = 0; i < _entryList.Count; i++)
        {
          
            Console.WriteLine(_entryList[i]);
            Console.WriteLine();
        }

    }

    public Entry()
    {

    }
}