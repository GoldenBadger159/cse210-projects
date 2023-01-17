using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try and guess the magic number between 1 and 100");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guesses = 0;
        int correct = 0;

        while (correct == 0) {
            Console.WriteLine("What is your Guess");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == number) {
                Console.WriteLine("Correct!");
                guesses += 1;
                correct = 1;
            } else if (guess <= number) {
                Console.WriteLine("Higher");
                guesses += 1;
            } else if (guess >= number) {
                Console.WriteLine("Lower");
                guesses += 1;
            }

        }
    }
}