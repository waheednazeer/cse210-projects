public class ReflectingActivity : Activity
{
    // This actvity will help you reflect on times in your life when you have shown strength and
    // resilience. This will help you recognize the power you have and how you can use it in other aspects
    // of your life.
    private string[] _reflectingPrompt = {
    "___ Think of a time when you did something really difficult, ___",
    "___ Think of a time when you help someone by sacrificing own benefits, ___",
    "___ Think of a time when you got hidden help from God, ___",
    "___ Think of a time when you forgive someone who hurt you ___"    
    };
    private string[] _ponderingQuestions = {
    "> How did you feel when it was complete? ",
    "> What is your favorite thing about this experience? ",
    "> How will you describe this experiece to others? ",
    "> What did you learn from this experience? "    
    };

    public ReflectingActivity(string activityName, string actvityDescription) : base(activityName, actvityDescription)
{

}
public void DisplayReflectingPrompt()
{
    Random r = new Random();
    int index = r.Next(0, _reflectingPrompt.Length);

    Console.WriteLine($"\n{_reflectingPrompt[index]}\n");
}
public void DisplayPonderingQuestions()
{
    Random r = new Random();
    int index = r.Next(0, _ponderingQuestions.Length);
    Console.Write(_ponderingQuestions[index]);

}

public void RunReflectionActivity(string seconds)
{
    Console.WriteLine("\nConsider the following prompt:");
    DisplayReflectingPrompt();
    Console.WriteLine("When you have something in your mind, press enter to continue");
    Console.ReadLine();
    Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
    Console.Write("You may begin in... ");
    PauseTime();
    Console.Clear();
    Console.WriteLine();
    double d = int.Parse(seconds);
    DateTime startTime= DateTime.Now;
    DateTime endTime = startTime.AddSeconds(d);
    while (DateTime.Now < endTime)
    {
        DisplayPonderingQuestions();
        RunSpinner();
        
    }
    
}

}