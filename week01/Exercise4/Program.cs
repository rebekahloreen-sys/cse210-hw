using System;

class Program
{
    static void Main(string[] args)
    {


        List<int> numbersInList = new List<int>();
        int number = 1000;
        int addedNumbers = 0;
        int largestNumber = -1000000000;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {

            Console.Write("Enter a number: ");

            string entry = Console.ReadLine();
            number = int.Parse(entry);
            if (number != 0)
            {
                numbersInList.Add(number);
            }

        } while (number != 0);



        foreach (int place in numbersInList)
        {
            addedNumbers += place;
            if (place > largestNumber)
            {
                largestNumber = place;
            }
        }

        double average = (double)addedNumbers / numbersInList.Count;

        Console.WriteLine($"The sum is: {addedNumbers}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is {largestNumber}");


    }
}