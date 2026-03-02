using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addingnumbers
{
    internal class Program
    {
        /// <summary>
        /// A computer program that asks the user to enter two numbers (integers), adds the two numbers together then shows the sum of the two numbers back to the user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter your first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
    }
}
