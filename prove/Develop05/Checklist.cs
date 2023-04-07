using System;

public class Checklist: Goal
{
    private int _bonusPoints;
    private int _endAmount;
    private int _currentAmount = 0;

    public int GetCurrentAmount()
    {
        return _currentAmount;
    }

    public void SetCurrentAmount(int current)
    {
        _currentAmount = current;
    }

    public int GetEndAmount()
    {
        return _endAmount;
    }

    public void SetEndAmount(int end)
    {
        _endAmount = end;
    }

    public int GetBonusPoints()
    {
        return _endAmount;
    }

    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
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
        SetCurrentAmount(0);
        Console.Write("How many times should this goal be accomplished? ");
        int end = int.Parse(Console.ReadLine());
        SetEndAmount(end);
        Console.Write("How many bonus points should full completion be worth? ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonusPoints(bonus);
    }

    public override List<string> FormatGoal()
    {
        List<string> goal = new List<string>();
        goal.Add("Checklist Goal"); //0
        goal.Add(GetName()); //1
        goal.Add(GetDescription()); //2
        goal.Add(GetPoints().ToString()); //3
        goal.Add(GetBonusPoints().ToString()); //4
        goal.Add(GetCurrentAmount().ToString()); //5
        goal.Add(GetEndAmount().ToString()); //6
        return goal;
    }
    public override void ListGoal(int itemNum, List<string> goal)
    {
        Console.WriteLine($"[] {itemNum}. {goal[0]}: {goal[1]} ({goal[2]}) -- Completed ({goal[5]}{goal[6]})");
    }
}