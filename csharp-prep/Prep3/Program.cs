using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string userGuess;
        int guess = number - 1;
        while (number != guess){
            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            if (guess > number) {
                Console.WriteLine("Lower");
            }
            else if (guess < number) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}