using System;

class Program
{
    static void Main(string[] args)
    {
        Library scriptureLibrary = new Library();
        Scripture scripture = scriptureLibrary.GetRandomScripture();


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
    }
    
}