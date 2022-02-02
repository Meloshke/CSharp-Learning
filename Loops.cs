using System;

// I used Brackeys Tutorial to learn C#

namespace CSharpLearningBeLike
{
    class Loops
    {
        static void Main(string[] args)
        {
            // For Loop

            Console.WriteLine("How many numbers do you want, BITCH????: ");
            int numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numberOfNumbers; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            Console.ReadKey();

            // While Loop

            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll a die");

            while(roll != 6)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts you fat, stupid fuck to roll a six");

            Console.ReadKey();
        }
    }
}