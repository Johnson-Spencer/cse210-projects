using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you helped this week?",
        "When have you felt peace recently?",
        "Who are your personal heroes?"
    };

    public ListingActivity() :
        base("Listing Activity",
            "This activity helps you reflect on the good things in your life.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine("\n--- " + _prompts[rand.Next(_prompts.Count)] + " ---");

        Console.Write("\nYou may begin in: ");
        Countdown(3);
        Console.WriteLine();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        List<string> items = new List<string>();

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine("\nYou listed " + items.Count + " items!");

        EndMessage();
    }
}
