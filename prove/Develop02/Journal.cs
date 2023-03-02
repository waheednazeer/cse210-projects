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
                // listing all available files to load.
        DirectoryInfo d = new DirectoryInfo(@"./data/"); 

        FileInfo[] Files = d.GetFiles(); //Getting all files in this directory/folder.
        int count = 0;
        foreach(FileInfo file in Files )
        {
            count++;
            Console.WriteLine($"{count}. {file.Name}");
        }
        Console.Write("Please enter any file name from above list: ");
        string filename = "./data/"+Console.ReadLine();
        Console.WriteLine();


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