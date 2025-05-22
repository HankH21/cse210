using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicNum = randomgenerator.Next(1, 101);


        int guess = 0;

        while (guess != magicNum)
        {


            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");

            }

            else if (guess > magicNum)
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