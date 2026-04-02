public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"you spent {_duration} seconds in the {_name} activity");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        int secondsFreed = 0;
        while (secondsFreed != seconds)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            secondsFreed = secondsFreed + 1;
        }
    }
    public void ShowCountDown(int seconds)
    {
        
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
}