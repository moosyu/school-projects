using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumbers
{
    internal class Program
    {
        /// <summary>
        /// takes an upper bound from the user and finds all prime numbers between 1 and that upper bound
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declare variables
            int userPrime;
            bool isPrime = true;
            List<int> primes = new List<int>();
            // read in the maximum from the user
            Console.WriteLine("Enter a number.");
            while (int.TryParse(Console.ReadLine(), out userPrime) && userPrime > 1)
            {
                // for each number between one and userPrime
                for (int i = 2; i < userPrime; i++)
                {
                    // check if number is prime
                    for (int j = 2; j < i; j++)
                    {
                        if (i%j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    // if the number is prime, output it to listbox
                    if (isPrime == true)
                    {
                        primes.Add(i);
                    }
                    // reset isPrime to false
                    isPrime = true;
                }
                Console.WriteLine("Primes:");
                for (int k = 0; k < primes.Count; k++)
                {
                    Console.WriteLine(primes[k].ToString());
                }
                primes.Clear();
                Console.WriteLine("Enter a number.");
            }
        }
    }
}
