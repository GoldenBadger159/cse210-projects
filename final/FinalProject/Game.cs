using System;

public class Game : World
{
    private static Player p = new Player();
    public void FindItem()
    {
        RollDice(p.GetBonus());
    }
}