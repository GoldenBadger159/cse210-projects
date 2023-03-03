using System;

public class Breathing : Activity
{
    private int _duration;
    public Breathing(string name, string description, int duration) : base(name, description){
        _duration = duration;
    }

    public void Breathe()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        bool done = false;
        do {
            Console.WriteLine("Breathe in");
            CountDown(5);
            Console.WriteLine("Breathe out");
            CountDown(5);
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                done = true;
            }
        } while (done == false);
    }
}