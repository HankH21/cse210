using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Doe", "Geography");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment massignment1 = new MathAssignment("Giorno Giovanna", "Algebra I", "9.3", "5-17");
        Console.WriteLine(massignment1.GetSummary());
        Console.WriteLine(massignment1.GetHomeworkList());

        WritingAssignment wassignment1 = new WritingAssignment("John Wick", "Reading Report", "The Worst Book");
        Console.WriteLine(wassignment1.GetSummary());
        Console.WriteLine(wassignment1.GetWritingInformation());
    }
}