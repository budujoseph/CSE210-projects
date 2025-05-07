using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredNumber);

    }

     static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userFavoriteNumber = int.Parse(Console.ReadLine());

            return userFavoriteNumber;
        }

        static int SquareNumber(int digit)
        {
            int square = digit * digit;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

}