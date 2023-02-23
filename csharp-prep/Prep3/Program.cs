using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int majic = randomGenerator.Next(1, 101);

        string response= "yes";
        string guess;
        int value;
        int count=0;
        while (response == "yes")
        {
            count++;
          Console.Write("Guess the majic number ");
            guess= Console.ReadLine();
            value=int.Parse(guess);
            if (value > majic)
            {
                Console.WriteLine("Majic number is Lower");
            }
            else if (value < majic)
            {
                Console.WriteLine("Majic number is Higher");
            }
            else
            {
                Console.WriteLine($"You guess it after {count} guesses.");
                Console.Write("Do you want to play again? ");
                response= Console.ReadLine();
                if (response== "yes")
                {
                    majic = randomGenerator.Next(1, 101);
                    count=0;
                }
            }
        }
    }
}