using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two integers that you want to compare! (include enter inbetween)");
                       
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());

            if (a > b) {
                Console.WriteLine(a + " is larger");
            } else if (b > a) {
                Console.WriteLine(b + " is larger");
            } else if (a == b) {
                Console.WriteLine("These numbers are equal!");
            } else {
                Console.WriteLine("Something went wrong");
            }    
            Console.ReadKey();


        }
    }
}
