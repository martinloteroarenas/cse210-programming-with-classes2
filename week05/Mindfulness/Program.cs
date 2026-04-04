using System;
/*I added an activity counter at lines 7, 37, 54, 71 and at the end of the program i display the number of activities done in line 75*/
class Program
{
    static void Main(string[] args)
    {
        int activitiesDone = 0;


        string answer = "";
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Breathing activity");
            Console.WriteLine("  2. Reflecting activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Type the number of your choice: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                breathingActivity.DisplayStartingMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for this activity? ");
                string duration = Console.ReadLine();
                int durationInt = int.Parse(duration);
                breathingActivity.SetDuration(durationInt);
                Console.Clear();
                Console.WriteLine("Get Ready...");
                breathingActivity.ShowSpinner(4);
                Console.Write("\b \b");
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                activitiesDone = activitiesDone + 1;
            }
            else if (answer == "2")
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60);
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for this activity? ");
                string duration = Console.ReadLine();
                int durationInt = int.Parse(duration);
                reflectingActivity.SetDuration(durationInt);
                Console.Clear();
                Console.WriteLine("Get Ready...");
                reflectingActivity.ShowSpinner(4);
                Console.Write("\b \b");
                reflectingActivity.Run();
                activitiesDone = activitiesDone + 1;
            }
            else if (answer == "3")
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity(0, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area in the duration of the activity.", 60);
                listingActivity.DisplayStartingMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for this activity? ");
                string duration = Console.ReadLine();
                int durationInt = int.Parse(duration);
                listingActivity.SetDuration(durationInt);
                Console.Clear();
                Console.WriteLine("Get Ready...");
                listingActivity.ShowSpinner(4);
                Console.Write("\b \b");
                listingActivity.Run();
                activitiesDone = activitiesDone + 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"You made {activitiesDone} activities today!");
    }
}