using System;

namespace CSharpLearningBeLike
{
    class Variables
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables";

            int num01;
            int num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            int result = num01 * num02;
            Console.WriteLine("\nThe result is: " + result);

            Console.ReadLine();

            // Challenge:
            // Write a programme which wants the user to input 3 different numbers
            // And then get the programme to calculate the average

            /*int number1;
            int number2;
            int number3;

            Console.Write("Input a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            int average = (number1 + number2 + number3) / 3;
            Console.WriteLine("\nThe average of these numbers is: " + average);

            Console.ReadLine();*/
        }
    }
}
