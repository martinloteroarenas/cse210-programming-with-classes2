using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int numberInt = PromptUserNumber();
        int squared = SquareNumber(numberInt);
        DisplayResult(name, squared);
    }

    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
   
   
   static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string number = Console.ReadLine();
        int numberInt = int.Parse(number);
        return numberInt;
    }


    static int SquareNumber(int numberInt)
    {
        int squared = numberInt * numberInt;
        return squared;
    }


    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is: {squared}");
    }
} 