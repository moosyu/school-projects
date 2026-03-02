using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmingbands
{
    internal class Program
    {
        /// <summary>
        /// Asks a user's age and then sorts them into which band they are in for swimming sports
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variables
            int userAge;
            // ask the user for their age
            Console.WriteLine("Please enter your age in years.");
            // get the users age from the console
            userAge = int.Parse(Console.ReadLine());
            // check if the user is in the junior band
            if (userAge < 14) {
                Console.WriteLine("You're a junior swimmer.");
            }
            else if (userAge < 16) {
                Console.WriteLine("You're a intermediate swimmer");
            }
            else if (userAge < 19) {
                Console.WriteLine("You're a senior swimmer");
            } else {
                Console.WriteLine("You're not a member of this school");
            }
        }
    }
}
