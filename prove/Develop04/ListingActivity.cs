public class ListingActivity : Activity
{
    private string[] _listingPrompt = {
    "--- When have you felt that you got direct help from God? ---",
    "--- When have you felt the holy Ghost this month? ---",
    "--- When did you feel that your wife did what you had in mind? ---",
    "--- In which course did you get 100% on your exam in the Winter 2023 semester? ---"    
    };
    
    public ListingActivity(string activityName, string actvityDescription) : base(activityName, actvityDescription)
{
  
}
public void RunListingActivity(string seconds)
{
    int count=0;
    Console.Write("You may begin in: ");
    PauseTime();
    Console.WriteLine();
    double d = int.Parse(seconds);
    DateTime startTime= DateTime.Now;
    DateTime endTime = startTime.AddSeconds(d);
    while (DateTime.Now < endTime)
    {
        Console.Write("> ");
        Console.ReadLine();
        count++;
    }
    Console.WriteLine($"You listed {count} items!");
}
public void DisplayListingPrompt()
{
    Random r = new Random();
    int index = r.Next(0, _listingPrompt.Length);
    Console.WriteLine(_listingPrompt[index]);

}

}