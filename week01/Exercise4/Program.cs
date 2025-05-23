using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputNumber = -1;
        List<int> numbers = new List<int>();

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        }

        int sum = 0;
        float average = 0;
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

        }

        Console.WriteLine($"The sum is: {sum}");

        average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is {largest}");

    }
}