public class Journal
{
    public List<Entry> _entries= new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        
    }

    public void SaveToFile()
    {
        Console.Write("Please enter file name: ");
        string fileName= "./data/"+Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            for (int i = 0; i < _entries.Count; i++)
            {
            outputFile.WriteLine(_entries[i]._entryList[i]);
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Please enter file name: ");
        string filename = "./data/"+Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);

        }
    }

    public void Display()
    {
      
        for (int i = 0; i < _entries.Count; i++)
        {
          
            _entries[i].Display();
            Console.WriteLine();
        }
    }


    public Journal()
    {

    }
}