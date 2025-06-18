using System.Data;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responces you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("Your may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> userStrings = GetListFromUser();
        
        _count = userStrings.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> userStrings = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string userInput = Console.ReadLine();
            userStrings.Add(userInput);
        }

        return userStrings;
    }

}