using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("section 5.5", "10-12", "pablo", "fractions");
        Console.WriteLine(mathAssignment1.GetSummary() + mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("the book of mormon", "moroni", "church history");
        Console.WriteLine($"{writingAssignment1.GetSummary()}");
        Console.WriteLine($"{writingAssignment1.GetWritingInformation()}");
    }
}   