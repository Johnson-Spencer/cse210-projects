using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() :
        base("Reflection Activity",
            "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("\n--- " + _prompts[rand.Next(_prompts.Count)] + " ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter.");
        Console.ReadLine();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("\nPonder on each of the following questions:");

        while (DateTime.Now < end)
        {
            string q = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("> " + q);
            ShowSpinner(5);
        }

        EndMessage();
    }
}
