using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your Grade percentage?(Number vales only please)");
        string Number = Console.ReadLine();
        int percent = int.Parse(Number);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulations, you did it, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Please see a TA or the Teacher if you need help!");
        }
    }

    
}