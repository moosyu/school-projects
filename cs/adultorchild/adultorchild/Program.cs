using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askingquestions
{
    internal class Program
    {
        /// <summary>
        /// A computer program that tells the user if they are an “adult” (otherwise they are a “child”).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            int answer = int.Parse(Console.ReadLine());
            if (answer < 18)
            {
                Console.WriteLine("Child");
            } else if (answer > 18) {
                Console.WriteLine("Adult");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
