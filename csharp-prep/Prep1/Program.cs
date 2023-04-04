using System;

class Program
{
  static void Main(string[] args)
  {
    List<string> m= new List<string>();
    Console.Clear();
    Console.Write("Please input: ");
    string user= Console.ReadLine();
    m.Add(user+"|");
    m.Add("|");
    string result="";

    string filename = "file.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {   
    for (int i = 0; i < m.Count; i++)
    {
    if (m[i] =="|")
    {
    m[i]="|";
    }
    outputFile.WriteLine(m[i]);
    outputFile.Close();          
    }
    string fileName="file.txt";
    string[] fileList = System.IO.File.ReadAllLines(fileName);
   
    foreach (string passenger in fileList)
    {
      
      result= result+"\n"+passenger;
            
    }

        string[] mm=result.Split("|");
          foreach (string f in mm)
          {
          Console.WriteLine(f);
          
          }

          

          
        


          
        }

  }
}
   
   
   /*
    {
        Console.Write("Enter your Percentage: ");
        string userValue= Console.ReadLine();
        int x= int.Parse(userValue);
        string letter;

        if (x >= 90)
        {
            if ((x % 10) > 3 )
            {
            letter="A";
            }
            else
            {
              letter="A-";   
            }
        }
        else if (x >= 80)
        {
           if ((x % 10) > 3 )
            {
            letter="B+";
            }
            else
            {
              letter="B-";   
            }
        }
        else if (x > 70)
        {
            if ((x % 10) > 3 )
            {
            letter="C+";
            }
            else
            {
              letter="C-";   
            }
        }
       
         else
        {
            letter="F";
        }

        if (x >70)
        {
            Console.WriteLine($"Congratulations you passed and got {letter}");
        }
        else
        {
          Console.WriteLine($"Next time work hard... {letter}");  
        }
    }
}*/