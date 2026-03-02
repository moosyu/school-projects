using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housetax
{
    internal class Program
    {
        /// <summary>
        /// A computer program that calculates the Annual Tax that must be paid on houses.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double housePrice, tax;
            Console.WriteLine("Enter the price of your house.");
            housePrice = double.Parse(Console.ReadLine());
            if (housePrice > 1000000)
            {
                tax = 1.02;
            } else if (housePrice <= 1000000 && housePrice > 750000)
            {
                tax = 1.015;
            } else if (housePrice > 500000 && housePrice < 750000)
            {
                tax = 1.01;
            } else
            {
                tax = 1;
            }
            Console.WriteLine($"${ ((housePrice * tax) - housePrice).ToString("F") } of tax @ { ((tax - 1) * 100).ToString("F") }%");
        }
    }
}
