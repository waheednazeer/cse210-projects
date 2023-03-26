using System;
class AllGoals
{
    private List<Goal> _allGoals = new List<Goal>();
    private int _totalPoints;
    private string _fileName;

    public void addGoal(Goal _goal)
    {
        _allGoals.Add(_goal);
    }

    public int getTotalPoints()
    {
        return _totalPoints;
    }

    public void DisplayPoints(int totalPoints)
    {
        
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void DisplayGoals()
    {
        if (_allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
            return;
        }
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _allGoals)
        {
            Console.WriteLine($"{_allGoals.IndexOf(goal) + 1}. {goal.ToString()}");
        }
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        if (_allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            Console.WriteLine();
            return;
        }
    
        Console.Write("Please enter the filename you want to save: ");
        _fileName = Console.ReadLine();
        string fileToSave = "./data/"+_fileName;
        List<string> saveGoals = new List<string>();
        //save points first
        saveGoals.Add(_totalPoints.ToString());
        foreach (Goal goal in _allGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        // listing all available files to load.
        DirectoryInfo d = new DirectoryInfo(@"./data/"); 

        FileInfo[] Files = d.GetFiles(); //Getting all files in this directory/folder.
        int count = 0;
        foreach(FileInfo file in Files )
        {
            count++;
            Console.WriteLine($"{count}. {file.Name}");
        }
        Console.Write("Please enter any file name from above list you want to load: ");
        List<string> fileGoals;
        _fileName = "./data/"+Console.ReadLine();
        fileGoals = SaveLoadCSV.LoadFromCSV(_fileName);
        _totalPoints = int.Parse(fileGoals[0]) + _totalPoints;

        Goal goal = null;
        foreach (string fileGoal in fileGoals)
        {
            
            string[] goalParts = fileGoal.Split('|');
            string goalType = goalParts[0];
            if (goalType == "Simple")
            {
                goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
            }
            else if (goalType == "Eternal")
            {
                goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), bool.Parse(goalParts[5]));
            }
            else if (goalType == "CheckList")
            {
                goal = new CheckListGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]), bool.Parse(goalParts[7]));
            }

            if (goal != null && _allGoals.Contains(goal) == false)
            {
                _allGoals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _allGoals)
        {
            Console.WriteLine(string.Format($"{_allGoals.IndexOf(goal) + 1}. [{((goal.GetGoalStatus() == false) ? " " : "x")}] {goal.GetGoalName()}"));
        }
        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        bool status = _allGoals[recordEvent].GetGoalStatus();
        if (status == false)
        {
            _allGoals[recordEvent].RecordEvent();
            _totalPoints += _allGoals[recordEvent].GetGoalPoints();
            Console.WriteLine(string.Format($"You now have {_totalPoints.ToString()} points!"));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You have already completed that goal!");
            Console.WriteLine();
        }
    }
}
