using System;

public class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Sandra", "Nature Studies");
        MathAssignment mathAssign = new MathAssignment("Sandra", "Nature Studies", "7.3", "8-19");
        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());



        Assignment assign2 = new Assignment("Sandra", "Medieval History");
        WritingAssignment writeAssign = new WritingAssignment("Sandra", "Medieval History", "Why Certain Messed-up Things Happened");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(writeAssign.GetWritingInformation());

    }
}