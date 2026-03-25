using System;
/*In addition i made the user can choose the difficulty of the program, the number he types is the number 
of words that will be hidden each time he press enter key, to make it work i added in the bottom a method
in the Scripture.cs named NumberOfNotHiddenWords() and i added a coupple if statements into the 
HideRandomWords() method for some specific cases, i did't need the Show() method in the Word class
to make the program work as described so i left it empty*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the number difficulty");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Normal");
        Console.WriteLine("3. Hard");
        string stringNumberToHide = Console.ReadLine();
        int intNumberToHide = int.Parse(stringNumberToHide);

        Reference reference1 = new Reference("John ", 3, 16, 17);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");

        bool isHidden = scripture1.IsCompletelyHidden();
        string answer = "k";
        Console.Clear();

        Console.WriteLine(reference1.GetDisplayText());
        Console.WriteLine(scripture1.GetDisplayText());

        while(answer != "q" && isHidden != true)
        {   
            Console.Write("Press enter to continue or type 'quit' to end the program :");
            answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            Console.Clear();
            scripture1.HideRandomWords(intNumberToHide);
            Console.WriteLine(reference1.GetDisplayText());
            Console.WriteLine(scripture1.GetDisplayText());
            isHidden = scripture1.IsCompletelyHidden();
        }
    }
}