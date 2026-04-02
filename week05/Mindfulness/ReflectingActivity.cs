public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration) : base (name, description, duration)
    {
    }

    public void Run()
    {
        DisplayRandomPrompt();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while(DateTime.Now < futureTime)
        {
            DisplayRandomQuestion();
            for(int i = 0; i < 8; i++)
            {
                ShowSpinner(1);
                if (DateTime.Now > futureTime)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        return _questions[randomIndex];
    }
    public void DisplayRandomPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
    }
    public void DisplayRandomQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}