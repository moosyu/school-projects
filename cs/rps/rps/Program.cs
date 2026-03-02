using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps
{
    internal class Program
    {
        /// <summary>
        /// A computer program that plays rock / paper / scissors.
        /// The program should ask the user to input their selection(rock, paper, or scissors) while also generating its own random selection between the three choices, 
        /// showing this onscreen(after the user has inputted their selection). 
        /// Tell the user who has one the round. Note: doing this is not as easy as it seems. If there is a draw, the computer and player keep going until someone wins the round.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random rand = new Random();
            string input;
            string[] options = { "rock", "paper", "scissors" };
            int comp = rand.Next(1, 3);
            input = Console.ReadLine().ToUpper();
            Console.WriteLine($"CPU played: {options[comp]}");
            if (input == "ROCK" && options[comp].ToUpper() == "PAPER")
            {
                Console.WriteLine("You lose");
            }
            else if (input == options[comp].ToUpper())
            {
                Console.WriteLine("You tie");
            }
            else if (input == "SCISSORS" && options[comp].ToUpper() == "PAPER")
            {
                Console.WriteLine("You win");
            }
            else if (input == "SCISSORS" && options[comp].ToUpper() == "ROCK")
            {
                Console.WriteLine("You lose");
                
            }
            else if (input == "ROCK" && options[comp].ToUpper() == "SCISSORS")
            {
                Console.WriteLine("You win");
            }
            else if (input == "PAPER" && options[comp].ToUpper() == "SCISSORS")
            {
                Console.WriteLine("You lose");
            }
            else if (input == "PAPER" && options[comp].ToUpper() == "ROCK")
            {
                Console.WriteLine("You win");
            }
        }
    }
}
