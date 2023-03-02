public class PromptGenerator
{
    public string _prompt="";
    string[] prompt= 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",                   
        "If I had one thing I could do over today, what would it be?"                                      
    };
    

    public void Prompt()
    {
        Console.WriteLine();
        Random randomPrompt = new Random();
       
            Console.WriteLine("Welcome to the Journal Prgoram!");
            Console.WriteLine("Please Select one of the below Choice:");
            Console.WriteLine("1: Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            int randomSelect = randomPrompt.Next(0, 5);
            _prompt= prompt[randomSelect];
            Console.Write("What would you like to do? ");  
 
    }
    public PromptGenerator()
    {

    }
}