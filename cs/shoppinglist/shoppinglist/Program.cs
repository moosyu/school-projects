using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppinglist
{
    internal class Program
    {
        /// <summary>
        /// Allows users to add groceries to a string then outputs that string as a completed shopping list.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declaring variables
            string shoppingList = "";
            string keepGoing = "";
            // asking user what they want to add
            Console.WriteLine("Kia ora! What do you want to add to your shopping list?");
            // add the first grocery item to the list
            shoppingList += Console.ReadLine();
            // check if the user is done
            Console.WriteLine("Would you like to add another item to your list (Yes/No)");
            keepGoing = Console.ReadLine().ToUpper();
            // this loop checks if the user is done
            while (keepGoing != "NO")
            {
                // ask for the next item on the list
                Console.WriteLine("What do you want to add next?");
                // add grocery item to the list
                shoppingList += ", " + Console.ReadLine();
                // check whether the user wishes to keep adding items
                Console.WriteLine("Would you like to add another item to your list (Yes/No)");
                keepGoing = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Your shopping list was: {shoppingList}");
        }
    }
}
