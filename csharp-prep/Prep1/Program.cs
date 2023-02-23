using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is first Name? ");
        string fname=Console.ReadLine();
        Console.Write("What is your last Name? ");
        string lname=Console.ReadLine();
        Console.WriteLine($"Your Name is  {lname}, {fname} {lname}.");
    }
}