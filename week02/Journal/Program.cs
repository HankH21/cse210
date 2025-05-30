using System;

class Program
{
    static void Main(string[] args)

    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome th the Journal Program!");
        string choice = "0";



        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();



            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.WriteLine("Please enter your response:");
                Console.Write(">");
                string userResponse = Console.ReadLine();


                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = userResponse;
                newEntry._date = DateTime.Now.ToShortDateString();

                myJournal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter file name to load:");
                string loadFileName = Console.ReadLine();
                myJournal.LoadFromFile(loadFileName);
            }

            else if (choice == "4")
            {
                Console.WriteLine("Enter file name to save:");
                string saveFileName = Console.ReadLine();
                myJournal.SaveToFile(saveFileName);
            }


            else
            {
                Console.WriteLine("Invalid choice! Please select from 1 to 5");
            }



        }

        Console.WriteLine("Goodbye!");
        

    }
}