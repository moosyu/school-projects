using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddoreven
{
    internal class Program
    {
        /// <summary>
        /// Checks if int is odd or even.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It's even");
            } else
            {
                Console.WriteLine("It's odd");
            }
        }
    }
}
