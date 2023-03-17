public class Activity
{
    private string _activityName;
    private string _actvityDescription;
    private string _activityDuration;

    public Activity(string activityName, string actvityDescription)
    {
        _activityName = activityName;
        _actvityDescription = actvityDescription;
    }

    public string GetActivityName()
    {
        return $"\nWelcome to the {_activityName}.";
    }
    public string GetActivityDescription()
    {
        Console.WriteLine();
        return $"{_actvityDescription}";
    }


    public void PauseTime()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            
        }
        
    }

    public void SetActivityDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = Console.ReadLine();
    }
        public string GetActivityDuration()
    {
       return _activityDuration; 
    }

    public void DisplayEndingActivityMessage()
    {
        Console.WriteLine("\nWell done!!");
        RunSpinner();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName}\n");
        RunSpinner();
    }
public void RunSpinner()
{
    string[] spin= {"|","/","-","\\","|","/","-","\\"};
        for (int i = spin.Length-1; i > 0; i--)
        {
            Console.Write(spin[i]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
        }

    Console.WriteLine();
  
}




}