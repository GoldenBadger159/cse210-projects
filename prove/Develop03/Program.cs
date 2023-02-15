using System;

class Program
{
    private static Index i = new Index();
    private static Scripture s = new Scripture();
    static void Main(string[] args)
    {

        Console.WriteLine("This is a random scripture memorizer.");

        string input = "";
        do {
            Console.WriteLine("To get a random scripture press \"enter\"\nTo hide a few words of the scripture press \"enter\"\nTo quit type 'quit' at any time.");
            input = Console.ReadLine();
            if (input != "quit")
            {
                s.Display();
                do {
                    input = Console.ReadLine();
                    if (input != "quit")
                    {
                        Console.Clear();
                        s.HideWords();
                        s.Display();
                    }
                } while (input != "quit");
            }
        } while (input != "quit");
    }
}