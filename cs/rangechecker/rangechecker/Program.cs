using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rangechecker
{
    internal class Program
    {
        /// <summary>
        /// a computer program that ask the user to enter a whole number between 1 and 100 (inclusive).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number?");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                Console.WriteLine("In range");
            } else
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
