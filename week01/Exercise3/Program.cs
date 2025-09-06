using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int guessNum = 0;
  

        while (magicNum != guessNum)
        {

            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();

            guessNum = int.Parse(guessNumber);


            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            if (guessNum == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}