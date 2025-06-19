using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2025, 6, 20), 45, 5.2));
        activities.Add(new Cycling(new DateTime(2025, 6, 17), 30, 40));
        activities.Add(new Swimming(new DateTime(2025, 6, 5), 45, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }    
}