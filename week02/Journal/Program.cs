using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        PromptGenerator aPrompt = new PromptGenerator();
        Journal aJournal = new Journal();

        do
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string randomPrompt = aPrompt.GetRandomPrompt();

                Console.WriteLine($"{randomPrompt}");
                string answer = Console.ReadLine();

                DateTime theCurrentDateTime = DateTime.Now;
                string dateText = theCurrentDateTime.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._date = dateText;
                anEntry._promptText = randomPrompt;
                anEntry._entryText = answer;

                aJournal.AddEntry(anEntry);
                /*Console.WriteLine($"{aJournal._entries[1]._entryText}");*/
            }
            else if (choice == "2")
            {
                aJournal.DisplayAll();
            }
            else if (choice == "4")
            {
                Console.Write("What is teh filename? ");
                string fileName = Console.ReadLine();
                aJournal.SaveToFile(fileName);
            }
            else if (choice == "3")
            {
                Console.Write("What is teh filename? ");
                string fileName = Console.ReadLine();
                aJournal.LoadFromFile(fileName);
            }
            
        } while (choice != "5");

        Console.WriteLine("GoodBye!");
        
    }
}