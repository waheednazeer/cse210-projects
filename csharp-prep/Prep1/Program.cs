using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is first Name? ");
        string first=Console.ReadLine();
        Console.Write("What is your last Name? ");
        string last=Console.ReadLine();
        Console.WriteLine($"Your Name is  {last}, {first} {last}.");
    }
}