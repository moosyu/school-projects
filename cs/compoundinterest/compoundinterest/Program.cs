using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compoundinterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pay = 55948;

            for (int i = 0; i < 10; i++)
            {
                pay *= 1.06;
                Console.WriteLine($"After {i + 1} year/s the pay is {pay}");
            }
        }
    }
}
