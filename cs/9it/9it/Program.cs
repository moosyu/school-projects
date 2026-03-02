using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9it
{
    internal class Program
    {
        // declare constants
        const int SAMPLE_SIZE = 9;
        const int NAT_AVERAGE = 132;
        const int UPPER_BOUND = 250;
        const int LOWER_BOUND = 100;
        // declare collections
        static int[] Heights = new int[SAMPLE_SIZE];
        /// <summary>
        /// Collects a sample of heights and returns the average and the range
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare varaibles
            string name;
            double mean, max, min;
            int currentHeight;
            // greet the user and ask for their name
            Console.WriteLine("Ni hao! What is your name?");
            name = Console.ReadLine();
            // for every height in the sample size
            for (int i = 0; i < SAMPLE_SIZE; i++)
            {
                // ask for a height
                Console.WriteLine("Please enter a height in cm");
                // check the entered number for validty and range
                while (int.TryParse(Console.ReadLine(), out currentHeight) == false || currentHeight < LOWER_BOUND || currentHeight > UPPER_BOUND)
                {
                    Console.WriteLine("Invalid input. Please enter a whole number between 100 and 250 inclusive, e.g. 158.");
                }
                // add the current height to our array
                Heights[i] = currentHeight;
            }
            max = Heights.Max();
            min = Heights.Min();
            mean = Heights.Average();
            if (mean > NAT_AVERAGE)
            {
                Console.WriteLine($"{name}, min was {min}, max was {max} and the mean was {mean}. That is {mean - NAT_AVERAGE} above the national average.");
            } else
            {
                Console.WriteLine($"{name}, min was {min}, max was {max} and the mean was {mean}. That is {NAT_AVERAGE - mean} below the national average.");
            }
        }
    }
}