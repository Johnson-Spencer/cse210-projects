using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.Write($"Your name is {lastname}, {firstname} {lastname}.");


        List<int> mylist = new List<int>();
        mylist.Add(10);
        mylist.Add(20);
        mylist.Add(30);

        int count = mylist.count();

        counsle.writeline($"The counnt is: {count}");

        int total = 0;
        for (int i = 0; i < mylist.Count; i++)
        {
            total = total + mylist[i];
        }

        Console.WriteLine($"The total is: {total}");


    }
}