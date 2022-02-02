using System;

// I used Brackeys Tutorial to learn C#

namespace CSharpLearningBeLike
{
    class Conditions
    {
        static void Main(string[] args)
        {
            int socialCredits = 10;
            Console.WriteLine("You've got " + socialCredits + " Social Credits in your wallet(don't ask how I know that)");
            Console.WriteLine("Welcome! Tickets are worth 5 Social Credits, please insert Social Credits.");

            int insertedSocialCredits = Convert.ToInt32(Console.ReadLine());

            if (insertedSocialCredits < 5) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yeah well, you fat fuck, you won't scam me >:)");
                Console.WriteLine("-5 Social Credits. Get Fucked! :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :(  hahah");
                socialCredits -= 100000009;
                Console.WriteLine("You've got " + socialCredits + " Social Credits in your wallet");
            }
            else if (insertedSocialCredits == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good Job, you didn't try to scam me, here's 10 Social Credits \n+10 Social Credits");
                socialCredits -= 5;
                socialCredits += 10;
                Console.WriteLine("You've got " + socialCredits + " Social Credits in your wallet");
            }
            else
            {
                int change = insertedSocialCredits - 5;
                Console.WriteLine("Here is your ticket and " + change + " Social Credits in change");
            }

            Console.ReadLine();
        }
    }
}