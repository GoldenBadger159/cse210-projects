using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        //Asks the users for first and last name then displays their input.
        Console.WriteLine("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string LastName = Console.ReadLine();
        Console.WriteLine($"Your name is {FirstName} {LastName}");
    }
}