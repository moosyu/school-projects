using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (double i = 1; i < 1000; i++)
            {
                if ((i / 3) % 1 == 0)
                {
                    j++;
                    Console.WriteLine(i + " is divisible by 3.");
                }
            }
            Console.WriteLine("There were " + j + " numbers between 1 and 1000 divisible by 3!");
        }
    }
}
