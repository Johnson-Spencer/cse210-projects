using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine(_description);
        Console.Write("\nHow long would you like this activity to last (in seconds)? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(4);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine("\nYou completed the " + _name + " for " + _duration + " seconds.");
        ShowSpinner(4);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSpinner(int seconds)
    {
        string[] spin = { "|", "/", "-", "\\" };

        DateTime end = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(spin[index]);
            Thread.Sleep(200);
            Console.Write("\b");
            index = (index + 1) % spin.Length;
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }
}
