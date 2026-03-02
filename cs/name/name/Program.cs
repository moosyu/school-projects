using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asking name
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Kia ora {name}");
        }
    }
}
