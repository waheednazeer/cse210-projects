using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference r = new Reference("Genesis", 1, 1);
        Word w = new Word("In the beginning God created the heaven and the earth.");
        Scripture s= new Scripture(r, w);

        
       
        string prompt="";
        while (prompt != "exit" && !s.IsCompletelyHidden())
        {
            
            //w.Show();
            Console.WriteLine(s.GetRenderedText());
            //Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or write 'exit' to stop:"); 
            prompt = Console.ReadLine();
            Console.Clear(); 
            s.HideWords();
        }
        

    }
}