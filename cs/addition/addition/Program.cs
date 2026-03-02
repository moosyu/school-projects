using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    internal class Program
    {
        /// <summary>
        /// take and validate two numbers from the console and add them together
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variable
            int num1, num2, sum;
            
            // ask the user for the first number
            Console.WriteLine("Hello, please enter a whole number!");
            
            // get the first number from the console
            while(!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid, try again.");
            }
            
            
            // ask the user for the second number
            Console.WriteLine("Please enter another whole number!");
            // get the second number from the console
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid, try again.");
            }

            // sum the numbers together
            sum = num1 + num2;
            // outputting the sum
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}
