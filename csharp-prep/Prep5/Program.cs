using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        DisplayResult();


    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName= Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
           Console.Write("Please enter your Number: ");
            string userNumber= Console.ReadLine();
            int number= int.Parse(userNumber);
            return number; 
        }

        static int SquareNumber(int anyNumber)
        {
            int sqr= anyNumber * anyNumber;
            return sqr;
        }

        static void DisplayResult()
        {
            string name= PromptUserName();
            int number= PromptUserNumber();
            int square= SquareNumber(number);
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}