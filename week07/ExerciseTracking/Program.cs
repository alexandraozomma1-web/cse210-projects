using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Created a list to hold different types of activities (Polymorphism)
        List<Activity> activities = new List<Activity>();

        // 2. Generated at least one of each activity type with sample data
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 25, 20);

        // 3. Added them all to the same list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // 4. Iterate through the list and display the summary for each activity
        Console.WriteLine("Exercise Tracking Summary:\n");
        foreach (Activity activity in activities)
        {
            // Polymorphism calls the correct GetSummary() method for each specific object type
            Console.WriteLine(activity.GetSummary());
        }
    }
}