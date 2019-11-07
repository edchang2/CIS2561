using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> digits = new Stack<char>();
            Console.WriteLine("Enter a positive number");
            int x = Convert.ToInt32(Console.ReadLine());

            do
            {
                int d = x % 10;
                digits.Push((char) ('0' + d));
                x /= 10;
            } while ( x != 0);

            string s = new string(digits.ToArray());

            Console.WriteLine("\"" + s + "\"");

            Console.ReadKey();




        }
    }
}
