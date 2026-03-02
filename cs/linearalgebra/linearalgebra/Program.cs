using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearalgebra
{
    internal class Program
    {
        /// <summary>
        /// A linear algebra equation to calculate the profits (or loss) made from a sausage sizzle fundraiser.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double numS = int.Parse(Console.ReadLine());
            const int PRICE = 50;
            const double PPS = 1.5;
            double final = (PPS * numS) - PRICE;
            Console.WriteLine($"You made ${final}");
            if (final > 0)
            {
                Console.WriteLine("You made $" + final);
            } else if (final < 0)
            {
                Console.WriteLine("You lost $" + final);
            } else
            {
                Console.WriteLine("You made $0");
            }
        }
    }
}
