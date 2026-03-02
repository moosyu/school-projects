using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canteen
{
    internal class Program
    {
        /// <summary>
        /// A computer program that calculates and applies a discount
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double cost, discountAmount, amountToPay, discountPercentage;
            Console.WriteLine("Enter the cost of your product.");
            cost = double.Parse(Console.ReadLine());
            if (cost < 5)
            {
                discountPercentage = 1;
            } else if (cost >= 5 && cost <= 7)
            {
                discountPercentage = 0.95;
            } else if (cost > 7 && cost < 10)
            {
                discountPercentage = 0.90;
            } else
            {
                discountPercentage = 0.85;
            }
            amountToPay = cost * discountPercentage;
            discountAmount = cost - amountToPay;
            Console.WriteLine($"Your discount amount is ${discountAmount.ToString("F")} meaning you have to pay ${amountToPay.ToString("F")}. That is a {(discountPercentage - 1) * -100}% discount");
        }
    }
}
