using System;

/*
CREATIVITY FEATURE:
1. I added a static `_activityCount` counter in the `Activity` base class 
   to track and display the total number of mindfulness exercises completed across the current session upon finishing each exercise.
2. I also updated `ReflectionActivity` to maintain a dynamic pool of unused questions. 
   Questions are picked randomly without repeating until all available questions have been displayed at least once, 
   at which point the pool of questions automatically resets.
*/

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"\n[Session Total Completed Activities: {Activity.GetActivityCount()}]");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nHave a  nice day! Goodbye!");
            }
        }
    }
}