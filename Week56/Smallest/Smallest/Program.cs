using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert the number of values, then the values you want to compare: ");
            string input = Console.ReadLine();
            string[] array = input.Split(null);
            int howMany = Convert.ToInt32(array[0]);
            int smallest = Convert.ToInt32(array[1]);

            for (int i = 1; i < howMany; i++)
            {
                int number = Convert.ToInt32(array[i + 1]);
                if (smallest > number)
                {
                    smallest = number;
                }

            }

            Console.WriteLine("The smallest number is " + smallest);
            Console.ReadKey();

        }
    }
}
