using System;

public class Eternal: Goal
{
    public override List<string> FormatGoal()
    {
        List<string> goal = new List<string>();
        goal.Add("Eternal Goal");
        goal.Add(GetName());
        goal.Add(GetDescription());
        goal.Add(GetPoints().ToString());
        return goal;
    }
    public override void ListGoal(int itemNum, List<string> goal)
    {
        Console.WriteLine($"[] {itemNum}. {goal[0]}: {goal[1]} ({goal[2]})");
    }
}