using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry= new Entry();
        Journal journal = new Journal();
        DateTime theCurrentTime;
        string dateText;
        


        PromptGenerator prompt= new PromptGenerator();
        string menu="";

        while (menu != "5")
        {
            prompt.Prompt();
            menu=Console.ReadLine();
            if (menu == "1")
            {
                theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{prompt._prompt}");
                Console.Write("> ");
                entry._userEntry=Console.ReadLine();
                entry._userEntry= $"Date: {dateText} - Prompt: {prompt._prompt} \n{entry._userEntry}";
                entry._entryList.Add(entry._userEntry);
                journal.AddEntry(entry);
                
            }

            if (menu == "2")
            {
                journal.Display();
            }
            if (menu == "4")
            {
                journal.SaveToFile();
            }
            if (menu == "3")
            {
                journal.LoadFromFile();
            }
        }
            

       
    





    }
}