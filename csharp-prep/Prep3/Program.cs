using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(0, 101);
        string userGuess;
        int guess = -1;
        Console.WriteLine("Random number between 0 - 100 is generated.");

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