using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("16 July 2024", 30, "Running", 4.8);
        Swimming swimming = new Swimming("15 July 2024", 60, "Swimming", 20);
        Cycling cycling = new Cycling("14 July 2024", 30, "Cycling", 10);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach(Activity activity in activities){
            activity.GetSummary();
        }
    }
}