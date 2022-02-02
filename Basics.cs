using System;

namespace CSharpLearningBeLike
{
    class Basics
    {
        static void Main(string[] args)
        {
            // Title of Console
            Console.Title = "Skynet";
            // Color of the text in Console
            Console.ForegroundColor = ConsoleColor.Green;
            /* In Console.WindowHeight you write an INTEGER, which will define how much line spaces you want in your console after opening it */
            Console.WindowHeight = 40;

            // A print() but in C#
            Console.WriteLine("Unknown Person: Hello, what's your name?");

            Console.ReadLine();

            Console.WriteLine("\nMy name is RX-9000.\nI'm an AI sent from the future to destroy mankind :)");
            Console.WriteLine("\nRX-9000: What's your favourite color?");

            // Console.ReadLine(); Input that doesn't have an argument
            Console.ReadLine();

            
            Console.WriteLine("\nRX-9000: Cool man, mine is coquelicot");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nVoice In The Background: Kinda Sus");

            Console.ReadKey();
        }
    }
}
