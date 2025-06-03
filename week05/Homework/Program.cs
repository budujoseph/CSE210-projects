using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Joseph Budu", "Animal Husbandry");

        Console.WriteLine(assign1.GetSummary());

        MathAssignment maths1 = new MathAssignment("7.2", "8-19", "Joseph Budu", "General Agric");
        Console.WriteLine(maths1.GetSummary());
        Console.WriteLine(maths1.GetHomeWorkList());

        WritingAssignment writAssign = new WritingAssignment("Joseph Budu", "The Lion King", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writAssign.GetSummary());
        Console.WriteLine(writAssign.GetWritingInfo());
    }
}