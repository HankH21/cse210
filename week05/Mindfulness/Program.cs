//I created a new class "Tracker" to track user performance, including how many times each activity was performed and total time duration.
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        Tracker activityTracker = new Tracker();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an option from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                activityTracker.TrackingUsage("Breathing", breathingActivity.GetDuration());
            }

            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                activityTracker.TrackingUsage("Reflecting", reflectingActivity.GetDuration());
            }

            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                activityTracker.TrackingUsage("Listing", listingActivity.GetDuration());

            }

            else if (choice == "4")
            {
                Console.WriteLine("Have a good day!");
                Console.WriteLine();
                activityTracker.DisplaySummary();
                break;
            }

            else
            {
                Console.WriteLine("Invalid option! Please enter a number from (1-4).");
                Thread.Sleep(3000);
            }


        }
    }
}