using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public List<string> _prompts = new List<string>
    {
        "What is something crazy that happened today?",
        "What is a quote or saying that you want to remember form today?",
        "What is something you realized you wish other people did? Why?",
        "What is soemthing you hope you remember 5 years from now about today?",
        "What promptings did you feel to do today?",
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
}

