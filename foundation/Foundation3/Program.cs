using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("03 Nov 2022", 30, 5),       // 5 km in 30 minutes
            new CyclingActivity("04 Nov 2022", 40, 25),      // Speed: 25 kph
            new SwimmingActivity("05 Nov 2022", 20, 30)      // 30 laps in 20 minutes
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
