using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectsquare
{
    internal class Program
    {
        /// <summary>
        /// a computer program that works out if an integer (input by the user) is a perfect square (meaning the square root of that number is a whole number).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            double num = double.Parse(Console.ReadLine());
            if (Math.Sqrt(num) % 1 == 0 && num > 0)
            {
                Console.WriteLine("This is a perfect square");
            } else
            {
                Console.WriteLine("This is not a perfect square");
            }
        }
    }
}
