using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers. (enter between them!)");
            
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            //sum
            double sum = a + b;
            Console.WriteLine("Sum: " + sum);

            //product
            double product = a * b;
            Console.WriteLine("Product: " + product);

            //difference
            double difference = a - b;
            Console.WriteLine("Difference: " + difference);

            //division
            double division = a / b;
            Console.WriteLine("Division: " + division);

            Console.ReadKey();

        }
    }
}
