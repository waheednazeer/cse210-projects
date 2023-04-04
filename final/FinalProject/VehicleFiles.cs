public class VehicleFiles
{
    public List<Vehicle> _entries= new List<Vehicle>();




    public void SaveToFile(string newFile,List<string> newList)
    {
        //Console.Write("Please enter file name: ");
        string fileName= "./data/"+newFile;
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            for (int i = 0; i < newList.Count; i++)
            {
                outputFile.WriteLine(newList[i]);
            }
        }
    }

    public void LoadFromFile(string newFile, List<string> seatList)
    {
        int line=0;
        Console.Clear();
        Console.WriteLine("Available Seats: [ ] | Booked Seats: [X]\n");
    

        string filename = "./data/"+newFile;
        if (!File.Exists(filename))
        {
            File.Create(filename); 
        }
        Console.WriteLine();

        string[] fileList = System.IO.File.ReadAllLines(filename);
        foreach (string item in fileList)
        {
            Console.Write(item);
            seatList[line] = item;
             line++;
            if (line%6==0)
            {
                Console.WriteLine();
            }
       
        Console.WriteLine();
        }
    }

     public void LoadPassengerFile(string newFile, List<string> passengerList)
    {
    
        Console.Clear();
        string filename = "./data/"+newFile;
        Console.WriteLine();

        string[] fileList = System.IO.File.ReadAllLines(filename);
        foreach (string passenger in fileList)
        {
            Console.WriteLine($"{passenger}");
            
        }
        Console.ReadLine();
    }
        public void SavePassengerFile(string fileName,List<string> passengerList)
    {
        
        //Console.Write("Please enter file name: ");
        fileName= "./data/"+fileName;
 
        StreamWriter outputFile = new StreamWriter(fileName, append:true);
        
        using (outputFile)
        {   
            for (int i = 0; i < passengerList.Count; i++)
            {
                outputFile.WriteLine(passengerList[i]);
              
            }
        }

     

    }

}