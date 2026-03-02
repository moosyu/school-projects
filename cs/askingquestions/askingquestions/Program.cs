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
        /// A computer program that asks the user some simple yes/no questions then respond to their answer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Do you like chocolate? (yes or no)");
            answer = Console.ReadLine().ToUpper();
            while (answer != "YES" && answer != "NO") {
                Console.WriteLine("Do you like chocolate? (yes or no)");
                answer = Console.ReadLine().ToUpper();
            }
            if (answer == "YES") {
                Console.WriteLine("I like chocolate too");
            } else
            {
                Console.WriteLine("Fine, I won’t share my chocolate with you");
            }
        }
    }
}
