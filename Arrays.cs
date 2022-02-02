using System;
// Importing Lists(yes you have to import it, kinda stupid and SUS)
using System.Collections.Generic;

// I used Brackeys Tutorial to learn C#

namespace CSharpLearningBeLike
{
    class Loops
    {
        static void Main(string[] args)
        {
            // Arrays

            string[] movies = new string[4];

            Console.WriteLine("Type in four movies: ");
            
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            // Lists

            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Pony's Fecies");
            shoppingList.Add("Rainbow Pills");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(0);

            Console.WriteLine("------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.ReadKey();
        }
    }
}