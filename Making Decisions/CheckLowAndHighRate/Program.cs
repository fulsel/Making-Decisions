using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double payrate;
            Console.Write("Enter your hourly pay rate here. ");
            input = Console.ReadLine();
            payrate = Convert.ToDouble(input);

            if (payrate < 5.65)
            {
                Console.WriteLine("Error, your hourly pay rate is too low.");
            }
            else if (payrate > 49.99)
            {
                Console.WriteLine("Error, your hourly pay rate is too high.");
            }


        }
    }
}
