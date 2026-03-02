using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmicalc
{
    internal class Program
    {
    /// <summary>
    /// calculates the bmi of the user
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.WriteLine("What's your weight?");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your height in metres ?");
            height = double.Parse(Console.ReadLine());
            bmi = weight / Math.Pow(height, 2);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi}, you are underweight!");
            } else if (bmi > 25)
            {
                Console.WriteLine($"Your BMI is {bmi}, you are overweight!");
            } else
            {
                Console.WriteLine($"Your BMI is {bmi}, you good.");
            }
        }
    }
}
