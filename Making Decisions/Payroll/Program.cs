using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Please enter your hourly payrate. ");
            input = Console.ReadLine();
            double payrate = Convert.ToDouble(input);

            Console.Write("Please enter your hours worked. ");
            input = Console.ReadLine();
            double hours = Convert.ToDouble(input);

            double gross = (payrate * hours);

            double withholdingless = (gross * 0.1);
            double withholdinggreater = ( gross * 0.12);

            double netpayless = (gross - withholdingless);
            double netpaygreater = (gross - withholdinggreater);


            if (gross <= 300.00)
            {
                Console.WriteLine("");
                Console.WriteLine("Your net pay is {0}", netpayless.ToString("C"));
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Your net pay is {0}", netpaygreater.ToString("C"));
            }

        }
    }
}
