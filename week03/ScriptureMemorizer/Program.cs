using System;

public class Program
{
    static void Main(string[] args)
    {


        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");


        while (scripture.IsCompletelyHidden() != true)
        {

            Console.Clear();


            Console.WriteLine(scripture.GetDisplayText());


            Console.WriteLine("Press enter to show less words or type quit to leave.");
            string userInput = Console.ReadLine();


            if (userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords(2);

        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}