using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float grade_value = float.Parse(grade);
        string grade_letter = "";

        if (grade_value >= 90)
        {
            grade_letter = "A";
        }

        else if (grade_value >= 80)
        {
            grade_letter = "B";
        }

        else if (grade_value >= 70)
        {
            grade_letter = "C";
        }

        else if (grade_value >= 60)
        {
            grade_letter = "D";
        }

        else
        {
            grade_letter = "F";
        }

        Console.WriteLine($"Your grade is: {grade_letter}");


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