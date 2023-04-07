using System;

public class Game
{
    private int _totalPoints;
    public void Save()
    {

    }
    public void Load()
    {

    }
    public void GainPoints(int points)
    {
        _totalPoints += points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}