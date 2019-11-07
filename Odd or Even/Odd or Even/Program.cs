using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it's odd or even!");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                number = Math.Abs(number);
            }

            if ((number % 2) == 0)
            {
                Console.WriteLine("The integer is even!");
            } else if ((number % 2) == 1)
            {
                Console.WriteLine("The integer is odd!");
            }

            Console.ReadKey();

        }
    }
}
