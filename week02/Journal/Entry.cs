using System;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _mood = "";

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} (Mood: {_mood}/10)");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}