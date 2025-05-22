using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float grade_value = float.Parse(grade);
        string gradeLetter = "";

        if (grade_value >= 90)
        {
            gradeLetter = "A";
        }

        else if (grade_value >= 80)
        {
            gradeLetter = "B";
        }

        else if (grade_value >= 70)
        {
            gradeLetter = "C";
        }

        else if (grade_value >= 60)
        {
            gradeLetter = "D";
        }

        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");


        if (grade_value > 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass this class!");
        }

    }
}