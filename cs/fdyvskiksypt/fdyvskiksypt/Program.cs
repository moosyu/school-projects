using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdyvskiksypt
{
    internal class Program
    {
        /// <summary>
        /// take a price without, calculates the gst and returns the new gst included price
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // delcare variables
            const double GST = 0.15;
            decimal initial, final;

            // ask the user to enter the inital price
            Console.WriteLine("Hello, please enter the price of your product!!");
            // get the inital price from the console
            while (!decimal.TryParse(Console.ReadLine(), out initial)) {
                Console.WriteLine("Please enter the price as a number, eg $2.50");
            }

            // calculate the cost with gst
            final = initial + initial * (decimal)GST;

            // output gst
            Console.WriteLine($"Your total with GST is {final.ToString("C")}");
        }
    }
}
