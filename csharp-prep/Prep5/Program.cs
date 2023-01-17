using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayWelcome () {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName () {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name; 
    }
    static int PromptUserNumber () {
        Console.WriteLine("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static double SquareNumber (int number) {
        double SquareNumber = Math.Pow(number, 2);
        return SquareNumber;
    }
    static void DisplayResult (string name, double SquareNumber) {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber}");
    }
}