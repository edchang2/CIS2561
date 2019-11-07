using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterickSquare
{
    class Program
    {

        public static void printX(String chara, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(chara);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Submit the size of the square: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("*");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            printX("*", number);
            Console.WriteLine("");

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("*");
                printX(" ", number - 2);
                Console.WriteLine("*");
            }

            printX("*", number);

            Console.ReadKey();
        }
    }
}

