using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int GetFavoriteNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string entry = Console.ReadLine();

            return int.Parse(entry);
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = GetFavoriteNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);


    }
}