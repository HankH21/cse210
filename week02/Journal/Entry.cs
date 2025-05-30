using System.Globalization;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _rateToday;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Satisfication Index: {_rateToday}/10 - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

}