public class BreathingActivity : Activity
{
    //private string _activityDetails= "This activity help you relax by walking you through breathing in and out slowly, clear your mind and focus on your breathing.";

public BreathingActivity(string activityName, string actvityDescription) : base(activityName, actvityDescription)
{

}
public void GetBreathingActivity()
{
    Console.WriteLine();
    Console.Write("Breathe in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
    Console.Write("\nBreathe out...");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
    Console.WriteLine();
}

public void RunBreathingActivity(string seconds)
{
    Console.Write("You may begin in... ");
    PauseTime();
    Console.WriteLine();
    double d = int.Parse(seconds);
    DateTime startTime= DateTime.Now;
    DateTime endTime = startTime.AddSeconds(d);
    while (DateTime.Now < endTime)
    {
        GetBreathingActivity();
        
    }
    
}


}