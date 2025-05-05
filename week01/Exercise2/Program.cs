using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int userScore = int.Parse(userGrade);
        // Console.WriteLine(userNumber);

        string letter = "";
        string sign = "";

        if (userScore >= 90)
        {
           letter = "A";
        }

        else if (userScore >= 80)
        {
            letter = "B";
        }

        else if (userScore >= 70)
        {
            letter = "C";
        }

        else if (userScore >= 60)
        {
             letter = "D";
        }

        else
        {
             letter = "F";
        }

        if (letter != "A" && letter != "F")
        {
            int lastDigit = userScore / 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }

            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (userScore > 70)
        {
            Console.WriteLine("Congratulations, You Passed!!");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!");
        }
    }

    
}