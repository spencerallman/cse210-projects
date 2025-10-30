using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Gary Patterson", "Division");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Spencer Rattler", "Algebra", "5.2", "1-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Chase Roberts", "Research Essay", "The Impact of Water Pollution on Frogs");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}