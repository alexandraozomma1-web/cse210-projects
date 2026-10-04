using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userItems = GetListFromUser();
        _count = userItems.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            // Check if user types before time expires
            string input = ReadLineWithTimeout(endTime);
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }

    private string ReadLineWithTimeout(DateTime endTime)
    {
        string input = "";
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: false);
                if (key.Key == ConsoleKey.Enter)
                {
                    return input;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (input.Length > 0)
                    {
                        input = input.Substring(0, input.Length - 1);
                    }
                }
                else
                {
                    input += key.KeyChar;
                }
            }
            System.Threading.Thread.Sleep(50);
        }
        return input; // Returns current input if timer expires mid-typing
    }
}