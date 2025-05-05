using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomNumbers = new Random();
        int number = randomNumbers.Next(1, 101);
        // Console.WriteLine(number);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Good job! you guessed it");
            }
        }
    }
}