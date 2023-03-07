using System;

class Program
{
    static void Main(string[] args)
    {
    
        
        Reference r1 = new Reference("Genesis", 1, 1);
        Reference r2 = new Reference("Doctrine and Covenants", 1,2);
        Reference r3 = new Reference("Jacob", 6, 13);
        Reference r4 = new Reference ("1 Nephi", 4, 6);
        Word w1 = new Word("In the beginning God created the heaven and the earth.");
        Word w2= new Word("For verily the voice of the Lord is unto all men, and there is none to escape; and there is no eye that shall not see, neither ear that shall not hear, neither heart that shall not be penetrated.");
        Word w3 = new Word("Finally, I bid you farewell, until I shall meet you before the pleasing bar of God, which bar striketh the wicked with awful dread and fear. Amen.");
        Word w4 = new Word("And I was aled by the Spirit, not knowing beforehand the things which I should do.");
        
        List<Reference> reference = new List<Reference>();
        reference.Add(r1);
        reference.Add(r2);
        reference.Add(r3);
        reference.Add(r4);
        List<Word> word = new List<Word>();
        word.Add(w1);
        word.Add(w2);
        word.Add(w3);
        word.Add(w4);
        Random random = new Random();
        int index = random.Next(0, word.Count);
        
        Scripture s= new Scripture(reference[index], word[index]);

        
       
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