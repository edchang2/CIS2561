using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a five digit integer: ");
            String input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Submission is incorrect.");
                System.Environment.Exit(1);
            }
            
            if ( input[0].Equals(input[4]) && input[1].Equals(input[3]))
            {
                Console.WriteLine("The submission is a palindrome");
            } else
            {
                Console.WriteLine("The submission is not a palindrome");

            }

            Console.ReadKey();

        }
    }
}
