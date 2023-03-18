using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity bA = new BreathingActivity ("Breathing Activity", "This activity help you relax by walking you through breathing in and out slowly, \nclear your mind and focus on your breathing.");
        ReflectingActivity rA = new ReflectingActivity ("Reflecting Activity", "This actvity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity lA = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can \nin a certain area.");
        
        int trackB = 0;
        int trackR = 0;
        int trackL = 0;

        string control="";
        while (control != "4")
        {
            Console.Clear();
            
            Console.WriteLine("Menue Option:");
            Console.WriteLine("  1: Start Breathing Activity");
            Console.WriteLine("  2: Start Reflecting Activity");
            Console.WriteLine("  3: Start Listing Activity");
            Console.WriteLine("  4: Quit");
            Console.Write("Select a choice from the menue: ");
            control = Console.ReadLine();
            if (control == "1")
            {
                trackB++;
                Console.Clear();
                Console.WriteLine(bA.GetActivityName());
                Console.WriteLine(bA.GetActivityDescription());
                Console.WriteLine();
                
                bA.SetActivityDuration();
                Console.Clear();
                Console.WriteLine("Get ready... ");
                bA.RunSpinner();
                bA.RunBreathingActivity(bA.GetActivityDuration());
                bA.DisplayEndingActivityMessage();    
            }
            
            if (control == "2")
            {
                trackR++;
                Console.Clear();
                Console.WriteLine(rA.GetActivityName());
                Console.WriteLine(rA.GetActivityDescription());
                Console.WriteLine();

                rA.SetActivityDuration();
                Console.Clear();
                Console.WriteLine("Get ready... ");
                rA.RunSpinner();
                rA.RunReflectionActivity(rA.GetActivityDuration());
                rA.DisplayEndingActivityMessage();
            }
            if (control == "3")
            {
                trackL++;
                Console.Clear();
                Console.WriteLine(lA.GetActivityName());
                Console.WriteLine(lA.GetActivityDescription());
                Console.WriteLine();

                lA.SetActivityDuration();
                Console.Clear();
                Console.WriteLine("Get ready... ");
                lA.RunSpinner();
                Console.WriteLine("List as many responses you can to following prompt:");
                lA.DisplayListingPrompt();
                lA.RunListingActivity(lA.GetActivityDuration());
                lA.RunSpinner();
               
                lA.DisplayEndingActivityMessage();                

            }

        }
        Console.Clear();
        Console.WriteLine("Actvities log...");
        rA.RunSpinner();
        Console.WriteLine($"You repeated Breathing Activity {trackB} times in this session.");
        rA.RunSpinner();
        Console.WriteLine($"You repeated Reflecting Activity {trackR} times in this session.");
        rA.RunSpinner();
        Console.WriteLine($"You repeated Listing Activity {trackL} times in this session.");
        
    }
}