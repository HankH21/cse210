using System.Security.Cryptography.X509Certificates;

public class Tracker
{
    private int _breathingCount = 0;
    private int _breathingTotalTime = 0;

    private int _reflectingCount = 0;
    private int _reflectingTotalTime = 0;

    private int _listingCount = 0;
    private int _listingTotalTime = 0;

    public void TrackingUsage(string type, int duration)
    {
        if (type == "Breathing")
        {
            _breathingCount++;
            _breathingTotalTime += duration;
        }

        else if (type == "Reflecting")
        {
            _reflectingCount++;
            _reflectingTotalTime += duration;
        }

        else if (type == "Listing")
        {
            _listingCount++;
            _listingTotalTime += duration;
        }

    }

    public void DisplaySummary()
    {
        Console.WriteLine("--- Activity Summary ---");
        Console.WriteLine($"> Breathing Activity: {_breathingCount} time(s), {_breathingTotalTime} seconds");
        Console.WriteLine($"> Reflecting Activity: {_reflectingCount} time(s), {_reflectingTotalTime} seconds");
        Console.WriteLine($"> Listing Activity: {_listingCount} time(s), {_listingTotalTime} seconds");


    }
}