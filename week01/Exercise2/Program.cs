using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeInteger = int.Parse(grade);
        string letter;
        if (gradeInteger > 90 || gradeInteger == 90)
        {
            letter = "A";
        }
        else if (gradeInteger > 80 || gradeInteger == 80)
        {
            letter = "B";
        }
        else if (gradeInteger > 70 || gradeInteger == 70)
        {
            letter = "C";
        }
        else if (gradeInteger > 60 || gradeInteger == 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Congrats your grade is {letter}, you pass the course!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}, You lose the course but you can do it better next time!");
        }
    }
}