using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringPercentage = Console.ReadLine();

        int percentage = int.Parse(stringPercentage);
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your grade is {letter}.");


        if (percentage >= 70)
        {
            Console.WriteLine("Congradulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed this time, but you can always try again!");
        }
    }
} 