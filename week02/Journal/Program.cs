
// Creativity:
// I added a mood rating system (1-10) to each journal entry so  user can track emotional state as they make entries into the journal.
// I also updated how entries are shown, saved, and loaded so the mood score stays saved and shows up on screen.

using System;
class Program
{
    static void Main(string[] args)
    {
        // 1. Create instances of our classes
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // Write a new entry
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("Rate your mood today (1-10): ");
                string userMood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                newEntry._mood = userMood;

                theJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                // Display all entries
                Console.WriteLine("\n--- Journal Entries ---");
                theJournal.DisplayAllEntries();
            }

            else if (userChoice == "3")
            {
                // Load entries from a file
                Console.Write("\nWhat is filename you want to load? ");
                string loadFilename = Console.ReadLine();
                theJournal.LoadFromFile(loadFilename);
                Console.WriteLine("Journal loaded successfully!");
            }
            else if (userChoice == "4")
            {
                // Save entries to a file
                Console.Write("\nWhat is the filename you want to save to? ");
                string saveFilename = Console.ReadLine();
                theJournal.SaveToFile(saveFilename);
                Console.WriteLine("Journal saved successfully!");
            }

            else if (userChoice == "5")
            {
                // Quit the program
                Console.WriteLine("\nThank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
 
        }
    }
}