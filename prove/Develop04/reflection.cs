using System;

public class Reflection : Activity
{
    private static Random random = new Random();
    private int _duration;
    public Reflection(string name, string description, int duration) : base(name, description){
        _duration = duration;
    }

    private List<string> _primaryPrompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _secondaryPrompts = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };

    private List<int> _used = new List<int>();

    private string GetPrimaryPrompt()
    {
        int index;
        int attempt = 0;
        bool found = false;
        do {
            index = random.Next(4);
            found = _used.Contains(index);
            attempt += 1;
            if (attempt > 100)
            {
                _used.Clear();
            }
        } while (found != false);

        _used.Add(index);
        string prompt = _primaryPrompts[index];
        return prompt;
    }
    
    private string GetSecondaryPrompt()
    {
        int index = random.Next(9);
        string prompt = _secondaryPrompts[index];
        return prompt;
    }

    public void Reflect()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        bool done = false;
        do {
            Pause(3);
            Console.WriteLine(GetPrimaryPrompt());
            CountDown(5);
            Console.WriteLine(GetSecondaryPrompt());
            CountDown(20);
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                done = true;
            }
        } while (done == false);
    }
}