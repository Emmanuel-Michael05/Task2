using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Hello, enter a number of choice   ");
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }

            Console.ReadKey();
        }
    }
}