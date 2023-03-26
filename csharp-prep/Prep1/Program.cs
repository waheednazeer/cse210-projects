using System;

class Program
{
    static void Main(string[] args)
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
}