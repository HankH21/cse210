public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of today?",
        "Describe one person you interacted with today.",
        "What did you learn today?",
        "What was the best food you had today?",
        "What was one thing you think you can do better from today?",
        "What was the strongest emotion I felt today?",
    };

    public string GetRandomPrompt()

    {
        Random _random = new Random();

        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}