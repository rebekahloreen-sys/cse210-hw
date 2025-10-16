using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Exercise> exercises = new List<Exercise>();
        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("Select which activity you did:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Biking");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Quit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("How long did you do this activity(in minutes)? ");
                int runningTime = int.Parse(Console.ReadLine());
                Console.Write("How far did you go(in miles)? ");
                float runningDistance = float.Parse(Console.ReadLine());
                exercises.Add(new RunningExercise(runningTime, runningDistance));
                break;
            }
            else if (choice == "2")
            {
                Console.Write("How long did you do this activity(in minutes)? ");
                int bikingTime = int.Parse(Console.ReadLine());
                Console.Write("How fast did you go(average mph)? ");
                float bikingSpeed = float.Parse(Console.ReadLine());
                exercises.Add(new BikingExercise(bikingTime, bikingSpeed));
                break;
            }
            else if (choice == "3")
            {
                Console.Write("How long did you do this activity(in minutes)? ");
                int swimmingTime = int.Parse(Console.ReadLine());
                Console.Write("How many laps did you do? ");
                float laps = float.Parse(Console.ReadLine());
                exercises.Add(new SwimmingExercise(swimmingTime, laps));
                break;
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please choose something else.");
                Console.WriteLine();
            }
        }
        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
        Console.WriteLine();


    }
}