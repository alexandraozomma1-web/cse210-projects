using System;
using System.Collections.Generic;
using System.IO;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {

        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }
    public void SaveToFile(string file)
    {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
        foreach (Entry entry in _entries)
        {
            // Make sure the order and separator match!
            outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
        }
    }
    }

    public void LoadFromFile(string file)
    {
    // Clear existing entries so loaded ones replace them
    _entries.Clear();

    // Check if the file actually exists first
    if (!File.Exists(file))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(file);

    foreach (string line in lines)
    {
        // Split using the exact same separator
        string[] parts = line.Split("~|~");

        if (parts.Length == 4)
        {
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            loadedEntry._mood = parts[3];

            _entries.Add(loadedEntry);
        }
    }
    }
}