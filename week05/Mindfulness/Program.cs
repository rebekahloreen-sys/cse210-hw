using System;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)

    {
        var ac = new Activity();
        var actBreathing = new BreathingActivity();
        var actReflecting = new ReflectingActivity();        
        var actListing = new ListingActivity();


        Console.Clear();
        Console.WriteLine("Thank you for taking the time to do this today!");
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine();
        Console.WriteLine("Please enter the number of the activity you would like to do: ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            actBreathing.Run();
        }
        else if (userInput == "2")
        {
            actReflecting.Run();
        }
        else if (userInput == "3")
        {
            actListing.Run();
        }
        else
        {
            Console.WriteLine("Oops! Something went wrong. Please restart the program.");
        }


    }
}