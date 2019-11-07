using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separate_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a five digit number!");

            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            double digit = Math.Ceiling(Math.Log10(number));
            if (number == 1)
            {
                digit = 1;
            }

            if (digit != 5)
            {
                Console.WriteLine("Not a five digit number, will randomize.");
                Random r = new Random();
                number = r.Next(10000, 99999);
            }

            int ones = number % 10;
            number /= 10;
            int tens = number % 10;
            number /= 10;
            int hundreds = number % 10;
            number /= 10;
            int thousands = number % 10;
            number /= 10;
            int tenthousands = number % 10;

            Console.WriteLine(tenthousands + "   " + thousands + "   " + hundreds + "   " + tens + "   " + ones);

            Console.ReadKey();



        }
    }
}
