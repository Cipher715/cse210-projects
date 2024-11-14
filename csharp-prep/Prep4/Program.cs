using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userInput;
        int number = 99;
        double sum = 0;
        int large = 0;
        double average = 0.0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0){
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0){
                numbers.Add(number);
            }
        }
        foreach (int num in numbers) {
            sum += num;
            if (num > large) {
                large = num;
            }
        }
        average = sum/numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The largest number is: {large}");
        Console.WriteLine($"The average is : {average}");


    }
}