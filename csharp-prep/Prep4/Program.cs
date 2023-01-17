using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int number = 0;
        int largestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do {
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
            if (number > largestNumber){
                largestNumber = number;
            }
        } while (number != 0);

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++) {
            sum += numbers[i];
        }

        int average = 0;
        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}