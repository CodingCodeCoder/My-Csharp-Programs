/*
    Assignment #1
    FizzBuzz
    Simon Dionne-Couture
    
    This program counts from 1 to 100 and replace every multiple of 3 and/or 5 with "Fizz", "Buzz" or "FizzBuzz".
 */

using System;
namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            { //this loop counts to 100
                if (i % 3 == 0 && i % 5 == 0)
                {//checks for multiples of 3 and 5 and display "FizzBuzz"
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {//checks for multiples of 3 and display "Fizz"
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {//checks for multiples of 5 and display "Buzz"
                    Console.WriteLine("Buzz");
                }
                else
                { //displays the count
                    Console.WriteLine(i);
                }
            }
        } // END OF MAIN
    }
}