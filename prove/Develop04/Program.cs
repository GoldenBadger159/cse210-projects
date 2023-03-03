using System;

class Program
{
    static Activity a = new Activity("null", "null");
    static void Main(string[] args)
    {
        string bDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        Console.WriteLine("The purpose of this program is to help you be more mindful of the blessings in your life.");
        Console.WriteLine("Here are three activities that can help with this:");
        Console.WriteLine("1. A Breathing Activity, 2. A Reflection Activity, 3. A Listing Activity");
        bool complete = false;
        do {
            Console.WriteLine("Please type 1, 2, or 3.");
            var input = Console.ReadLine();

            if (input == "1"){
                int duration = a.GetDuration();
                Breathing b = new Breathing("Breathing Activity", bDescription, duration);
                b.DisplayWelcome(duration);
                b.Breathe();
                b.DisplayEnd();
                complete = true;
            } else if (input == "2"){
                int duration = a.GetDuration();
                Reflection r = new Reflection("Reflection Activity", rDescription, duration);
                r.DisplayWelcome(duration);
                r.Reflect();
                r.DisplayEnd();
                complete = true;
            } else if (input == "3"){
                int duration = a.GetDuration();
                Listing l = new Listing("Listing Activity", lDescription, duration);
                l.DisplayWelcome(duration);
                l.List();
                l.DisplayEnd();
                complete = true;
            } else {
                complete = false;
            }
        } while (complete != true);
    }
}