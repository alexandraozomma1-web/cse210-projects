// creativity: I included an enhancement HideRandomWords() in Scripture.cs to only pick from words that are not already hidden 
// I also implemented a scripture library with random selection so a different scripture can be presented each time the program runs.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures for random selection
        List<(Reference Ref, string Text)> library = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believes in Him shall not perish but have eternal life."),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding, in all your ways submit to him,and he will make your paths straight."),
            (new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.")
        };

        Random rand = new Random();
        var selected = library[rand.Next(library.Count)];

        Scripture scripture = new Scripture(selected.Ref, selected.Text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        // Show final hidden state before exit
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }

}