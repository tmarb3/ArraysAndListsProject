using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers10 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var item in numbers10)
            {
                if (item % 2 == 0)
                {
                    evens.Add(item);
                }
                else
                {
                    odds.Add(item);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            for (int i = 0; i < evens.Count; i++)
                Console.WriteLine($"{evens[i]} this is even");
            for (int i = 0; i < odds.Count; i++)
                Console.WriteLine($"{odds[i]} this is odd");
        }
    }
}
