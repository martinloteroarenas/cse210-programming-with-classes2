public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while(DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe IN  ");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe OUT  ");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (DateTime.Now > futureTime)
            {
                break;
            }
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.WriteLine();
        }
    }
}