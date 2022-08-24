/*
    Exception Handling
    Simon Dionne-Couture

    This program handles Exceptions.
 */
using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {//Start of MAIN
            //Variable Initialization
            string inputA;
            string inputB;
            byte a;
            byte b;

            //User Input
            Console.WriteLine("Enter a number between 0 and 255:");
            inputA = Console.ReadLine();
            Console.WriteLine("Enter another number between 0 and 255:"); 
            inputB = Console.ReadLine();

            //Exception Handling
            try
            {
                a = Byte.Parse(inputA);
                b = Byte.Parse(inputB);
                Console.WriteLine($"{a} divided by {b} is: {a / b}");
            } //follow by catch block
            catch ( FormatException e ) { Console.WriteLine(e.Message); }
            catch ( OverflowException e ) { Console.WriteLine(e.Message); }
            catch ( DivideByZeroException e) { Console.WriteLine(e.Message); }
            catch ( Exception e ){ Console.WriteLine(e.Message); }
        }//END of MAIN
    }
}
