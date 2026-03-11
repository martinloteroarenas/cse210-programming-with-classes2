using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessInt;
        do
        {
            Console.Write("Guess the magic number: ");
            string guess = Console.ReadLine();
            guessInt = int.Parse(guess);
            if  (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
            }        
        } while (guessInt != magicNumber);

        Console.WriteLine("THAT IS THE HIDDEN NUMBER!");
    
    }
}