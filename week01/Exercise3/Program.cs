using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magic_num = randomgenerator.Next(1, 101);


        int guess = 0;

        while (guess != magic_num)
        {


            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_num)
            {
                Console.WriteLine("Higher");

            }

            else if (guess > magic_num)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
    
}