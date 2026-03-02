using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadraticformula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xSquared, x, constant;
            double intercept;
            Console.WriteLine("Enter the coefficent of x^2");
            xSquared = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coefficent of x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the constant");
            constant = int.Parse(Console.ReadLine());
            Console.WriteLine("Answer is: ");
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(-x + Math.Sqrt(x^2 - 4*(xSquared * constant)) / 2 * xSquared);
                } else
                {
                    Console.WriteLine(-x - Math.Sqrt(x ^ 2 - 4 * (xSquared * constant)) / 2 * xSquared);
                }
            }
        }
    }
}
