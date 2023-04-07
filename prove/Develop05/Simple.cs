using System;

public class Simple: Goal
{
    private bool _isDone;

    public bool GetIsDone()
    {
        return _isDone;
    }

    public void SetIsDone(bool done)
    {
        _isDone = done;
    }

    public override void CreateGoal()
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
        SetIsDone(false);
    }

    public override List<string> FormatGoal()
    {
        List<string> goal = new List<string>();
        goal.Add("Simple Goal");
        goal.Add(GetName());
        goal.Add(GetDescription());
        goal.Add(GetPoints().ToString());
        goal.Add(GetIsDone().ToString());
        return goal;
    }

    public override void ListGoal(int itemNum, List<string> goal)
    {
        if (goal[4] == "false"){
            Console.WriteLine($"[] {itemNum}. {goal[0]}: {goal[1]} ({goal[2]})");
        } else if (goal[4] == "true"){
            Console.WriteLine($"[x] {itemNum}. {goal[0]}: {goal[1]} ({goal[2]})");
        }
    }
}