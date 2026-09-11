using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the most challenging part of your day?");
        _prompts.Add("How did you handle a difficult situation today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the most important thing I learned today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}