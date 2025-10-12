using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Hello! Welcome to your Journal, what wouuld you like to do?");
            Console.WriteLine("1. New entry prompt");
            Console.WriteLine("2. Display Entrys");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(myJournal);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    SaveJournal(myJournal);
                    break;
                case "4":
                    LoadJournal(myJournal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Sorry, that wasnt a vaild Answer, please look again.");
                    break;


                    static void WriteNewEntry(Journal journal)
                    {
                        string prompt = journal.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Response: ");
                        string response = Console.ReadLine();
                    }

                    static void DisplayAll(Journal journal)
                    {
                        journal.DisplayAll();
                    }

                    static void SaveJournal(Journal journal)
                    {

                    }

                    static void LoadJournal(Journal journal)
                    {

                    }
            }


        }
    }
}