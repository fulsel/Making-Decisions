using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter \"P\" for Pine, \"O\" for Oak, or \"M\" for Mahogany. ");
            string input = Console.ReadLine().ToLower();

            if (input == "P" || input == "p")
            {
                Console.WriteLine("Pine tables cost $100.");
            }
            else if (input == "O" || input == "o")
            {
                Console.WriteLine("Oak tables cost $225.");
            }
            else if (input == "M" || input == "m")
            {
                Console.WriteLine("Mahongany tables cost $310.");
            }
            else // if (input != "P" || input != "p" || input != "O" || input != "o" || input != "M" || input != "m")
            {
                Console.WriteLine("Sorry, you did not enter a specified character. Please Try again.");
            }
        }
    }
}
