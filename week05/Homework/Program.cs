using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Joseph Budu", "Animal Husbandry");
        
        Console.WriteLine(assign1.GetSummary());
    }
}