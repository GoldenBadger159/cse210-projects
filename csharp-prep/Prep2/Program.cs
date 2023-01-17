using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade by percentage? ");
        string userGrade = Console.ReadLine();
        int percent = int.Parse(userGrade);
        string letterGrade = "";


        if (percent >= 90) {
            letterGrade = "A";
        } else if (percent >= 80) {
            letterGrade = "B";
        } else if (percent >= 70) {
            letterGrade = "C";
        } else if (percent >= 60) {
            letterGrade = "D";
        } else if (percent < 60) {
            letterGrade = "F";
        } else {
            Console.WriteLine("Not a valid entry.");
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (percent >= 70) {
            Console.WriteLine("Congrats you passed!");
        } else {
            Console.WriteLine("Better luck next time.");
        }
    }
    
    
}