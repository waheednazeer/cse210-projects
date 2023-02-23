using System;


class Program
{
    static void Main(string[] args)
    {

        List <int> numbers= new List<int> ();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int value=1;
        string enterValue;
        double sum=0;
        int largest=0;
        
        while (value > 0)
        {      
            
            Console.Write("Enter number: ");
            enterValue= Console.ReadLine();
            value=int.Parse(enterValue);
            if (value > 0)
            {
               numbers.Add(value);  
            }
           
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            sum=sum+numbers[i];
            if (largest < numbers[i])
            {
                largest=numbers[i];
            }
            
        }
        double average= sum / numbers.Count;
        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        
    }
}