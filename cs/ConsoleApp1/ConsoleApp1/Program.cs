using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        /// <summary>
        /// A program!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            // declares name variable
            string name = "";
            Console.WriteLine("What is your name?");
            // reads name
            name = Console.ReadLine();
            while (name == name)
            {
                Console.WriteLine("Hi Minghan " + name);
            }
            // writes name
            Console.ReadKey();
        }
    }
}