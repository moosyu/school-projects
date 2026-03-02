using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempconverter
{
    internal class Program
    {
        /// <summary>
        /// program that tells user if its hot cold or warm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Enter a temperature");
            temp = double.Parse(Console.ReadLine());
            if (temp < 10)
            {
                Console.WriteLine("Cold");
            } else if (temp > 50)
            {
                Console.WriteLine("Hot");
            } else
            {
                Console.WriteLine("Warm");
            }
        }
    }
}
