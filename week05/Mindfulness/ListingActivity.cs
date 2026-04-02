public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int count, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
    }

    public void Run()
    {
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        Console.Write("7");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        Console.WriteLine($"{_prompts[randomIndex]}");
    }
    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        string answer;

        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            answer = Console.ReadLine();
            Console.WriteLine();
            answers.Add(answer);
            
            _count = _count + 1;
        }
        return answers;
    }
}