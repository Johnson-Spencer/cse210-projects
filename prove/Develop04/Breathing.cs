using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() :
        base("Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);

            Console.Write("\nBreathe out... ");
            Countdown(4);
        }

        EndMessage();
    }
}
