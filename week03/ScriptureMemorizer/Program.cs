using System;

class Program
{
    static void Main(string[] args)
    {
             Reference reference = new Reference("D&C", 105, 3, 5);
        Scripture scripture = new Scripture(reference, "Hello guys my name is Pei-Han Hung test test test test test test test test test");


        while (!scripture.IsCompleteHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide random words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Goodbye!");
    }
    }
}