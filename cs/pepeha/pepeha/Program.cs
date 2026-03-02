using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pepeha
{
    internal class Program
    {
        /// <summary>
        /// A computer program that creates the users Pepeha in Te Reo by asking them a series of questions about their identity like their name, mountain and river.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string name, mountain, river;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your mountain?");
            mountain = Console.ReadLine();
            Console.WriteLine("What is your river?");
            river = Console.ReadLine();
            Console.WriteLine($"Your name is {name}, your mountain is {mountain} and your river is {river}");
        }
    }
}
