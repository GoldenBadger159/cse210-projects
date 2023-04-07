using System;
using System.Collections.Generic;

public class Explore : Game
{
    private static Player p = new Player();
    public void GoExploring()
    {
        var random = new Random();
        List<string> levels = GetLevels();
        bool selected = false;
        do {
            List<string> levelOptions = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string level;
                do {
                    level = levels[random.Next(levels.Count())];
                } while (!levels.Contains(level));
                levelOptions.Add(level);
                Console.WriteLine($"{i + 1}: {level}");
            }
            Console.Write("Which level would you like to go to?");
            string choice = Console.ReadLine();
            string destination = levelOptions[int.Parse(choice) - 1];
            int roll = RollDice(p.GetBonus());
            if (roll <= 5)
            {
                Console.WriteLine("You didn't find anything");
            } else if (roll >=6)
            {
                if (roll >= 18)
                {
                    Dictionary<string, int> weapons = GetWeapons();
                    Dictionary<string, int>.KeyCollection w = weapons.Keys;
                    List<string> weaponsL = w.ToList<string>();
                    string weapon = weaponsL[random.Next(weaponsL.Count())];
                    int damage = weapons[weapon];
                    Console.WriteLine($"You found a {weapon}.");
                    Console.WriteLine($"It can do {damage} damage.");
                    Console.Write("Would you like to equip it? ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes")
                    {
                        p.EquipWeapon(weapon);
                    } else
                    {
                        AddArmory(weapon, damage);
                        Console.WriteLine($"{weapon} added to storage.");
                    }
                }
                List<string> allGear = GetGear();
                string gear = allGear[random.Next(allGear.Count())];
                Console.WriteLine($"You found {gear}.");
                Console.Write("Would you like to equip it? ");
                string decision = Console.ReadLine();
                if (decision.ToLower() == "yes")
                    {
                        p.EquipGear(gear);
                    } else
                    {
                        AddStorage(gear);
                        Console.WriteLine($"{gear} added to storage.");
                    }
            }
        } while (selected == false);
        
    }
}