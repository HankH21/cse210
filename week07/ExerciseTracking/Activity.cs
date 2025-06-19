using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    protected DateTime _date;
    protected int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        string summary = $"{_date.ToString("dd MM yyyy")} {this.GetType().Name} ({_duration} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        return summary;
    }





}