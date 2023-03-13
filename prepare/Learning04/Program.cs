using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment mA = new MathAssignment ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment wA = new WritingAssignment ("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(mA.GetSummary());
        Console.WriteLine(mA.GetHomeworkList());

        Console.WriteLine(wA.GetSummary());
        Console.WriteLine(wA.GetWritingInformation());
    }
}