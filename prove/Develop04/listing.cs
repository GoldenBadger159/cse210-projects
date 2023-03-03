using System;

public class Listing : Activity
{
    private static Random random = new Random();

    public Listing(string name, string description, int duration) : base(name, description){
        _duration = duration;
    }

    private int _duration;

    private List<int> _used = new List<int>();

    private List<string> _prompts = new List<string>(){
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    public string GetPrompt()
    {
        int index;
        int attempt = 0;
        bool found = false;
        do {
            index = random.Next(5);
            found = _used.Contains(index);
            attempt += 1;
            if (attempt > 100)
            {
                _used.Clear();
            }
        } while (found != false);

        _used.Add(index);
        string prompt = _prompts[index];
        return prompt;
    }

    public void List()
    {
        int itemCount = 0;
        Console.WriteLine(GetPrompt());
        Pause(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        bool done = false;
        do {
            Console.ReadLine();
            itemCount += 1;
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                done = true;
            }
        } while (done == false);
        Console.WriteLine($"You listed {itemCount} items.");
    }
}