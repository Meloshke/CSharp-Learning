using System;

// I used Brackeys Tutorial to learn C#

namespace CSharpLearningBeLike
{
    class Loops
    {
        static void Main(string[] args)
        {
            // First Method
            MeetAlien();
            Console.WriteLine("----------");
            MeetAlien();
            Console.WriteLine("----------");
            MeetAlien();

            // Second Method
            int result = Multiply(3, 8);

            Console.WriteLine("The result is " + result + ".");

            if (result % 2 == 0)
            {
                Console.WriteLine("Result is an even number");
            }
            else
            {
                Console.WriteLine("Result is an odd number");
            }

            Console.ReadKey();
        }

        // MeetAlien() is a method without parameters and returned values,
        // Basically it's not as entertaining as a method with parameters and returned values would be.

        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(1, 9999);
            int age = numberGen.Next(1, 500);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi, I'm " + name + ".");
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, and I'm an alien.");
        }

        // Multiply() is a method with parameters and returned values

        static int Multiply (int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
    }
}