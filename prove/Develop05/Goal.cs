using System;

public class Goal
{
    private static Game game = new Game();
    private string _name;
    private string _description;
    private int _points;
    private int _goalType;
    private List<List<string>> _goals = new List<List<string>>();

    public void AppendGoals(List<string> goal)
    {
        _goals.Add(goal);
    }
    public List<List<string>> GetGoals()
    {
        return _goals;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points = 0;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetGoalType()
    {
        return _goalType;
    }
    public void SetGoalType()
    {
        Console.WriteLine("The different goal types are: ");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());
        _goalType = type;
    }
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points will this goal be worth? ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }
    public virtual List<string> FormatGoal()
    {
        List<string> goal = new List<string>();
        goal.Add("Goal Type");
        goal.Add(GetName());
        goal.Add(GetDescription());
        goal.Add(GetPoints().ToString());
        return goal;
    }
    public int GetEventIndex()
    {
        DisplayProgress();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        return goalIndex;
    }
    public virtual void RecordProgress(List<string> goal)
    {
        game.GainPoints(int.Parse(goal[3]));
    }
    public virtual void ListGoal(int itemNum, List<string> goal)
    {
        Console.WriteLine($"[] {itemNum}. {goal[0]}: {goal[1]} ({goal[2]})");
    }
    public void DisplayProgress()
    {
        Dictionary<string, Goal> type = new Dictionary<string, Goal>();
        type["1"] = new Eternal();
        type["2"] = new Simple();
        type["3"] = new Checklist();
        List<List<string>> goals = GetGoals();
        int itemNum = 1;
        foreach (List<string> goal in goals){
            string typeIndex = "0";
            if (goal[0] == "Eternal Goal"){
                typeIndex = "1";
            } else if (goal[0] == "Simple Goal"){
                typeIndex = "2";
            } else if (goal[0] == "Checklist Goal"){
                typeIndex = "3";
            }
            type[typeIndex].ListGoal(itemNum, goal);
        }
    }
}