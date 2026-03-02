using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fj
{
    internal class Program
    {
        /// <summary>
        /// Takes a number from the console and checks if it is even or odd
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variables
            int number;
            // ask the user for a number
            Console.WriteLine("Please enter a whole number.");
            //  get the number from the console
            number = int.Parse(Console.ReadLine());
            // check if the number is odd or even
            if (number%2 == 0) {
                Console.WriteLine(number.ToString() + " is even");    
            } else {
                Console.WriteLine(number.ToString() + " is odd");
            }
        }
    }
}
