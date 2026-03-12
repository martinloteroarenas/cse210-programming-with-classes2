using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int numberToAdd;
        do
        {
            Console.Write("Write a number or type 0 to quit:");
            string entry = Console.ReadLine();
            numberToAdd = int.Parse(entry);
            if (numberToAdd != 0)
            {
                numbers.Add(numberToAdd);   
            }
        }while (numberToAdd != 0);

        int sum = 0;
        int numbersAmmount = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
            numbersAmmount = numbersAmmount + 1;
            if(number > largest)
            {
                largest = number;
            }
        }
        double average = sum / numbersAmmount;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}