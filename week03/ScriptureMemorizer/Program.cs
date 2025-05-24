using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the book name: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter number: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the verse number: ");
        int verse = int.Parse(Console.ReadLine());

        Reference reference = new Reference(book, chapter, verse);

        Console.Write("Enter the scripture text: ");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(reference, scriptureText);
        
        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide words or press 'quite' to exit. ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quite")
            {
                break;
            }

            scripture.HideWords(3);

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("Congratulation! you have memorized the scripture");
                break;
            }
        }

        Console.WriteLine("Thank You!");
    }
}