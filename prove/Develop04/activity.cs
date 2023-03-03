using System;

public class Activity
{
    private string _name;

    private string _description;
    private DateTime _beggining;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public void DisplayWelcome(int duration)
    {
        Console.WriteLine($"This is the {_name}. {_description} {duration}");
        Console.WriteLine("Let's get ready to start.");
        _beggining = DateTime.Now;
    }

    public void DisplayEnd()
    {
        var interval = (DateTime.Now - _beggining).TotalMilliseconds;
        Console.WriteLine($"You've done a good job.");
        Pause(2);
        Console.WriteLine($"You completed the {_name}. It took {Math.Round(interval / 1000)} seconds.");
        Pause(3);
    }

    public void Pause(int time)
    {
        Thread.Sleep(time * 1000);
    }

    public int GetDuration()
    {
        Console.WriteLine("how long would you like to spend on this activity in seconds?");
        string input = Console.ReadLine();
        int seconds = Int32.Parse(input);
        return seconds;
    }

    public void CountDown(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            if (i > 9)
            {
                Console.Write("\r");
            } else
            {
                Console.Write("\r  \r");
            }
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("");
    }

    public int GetRandomIndex(int range)
    {
        int randIndex = 0;
        return randIndex;
    }

}