using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {

            double amount;
            int principal = 1000; //initial amount before interest
            double rate = .05;

            Console.WriteLine("Year{0, 20}", "Amount on deposit");
            for (int year = 1; year <=10; year++)
            {
                
                amount = principal * Math.Pow(1.0 + rate, year);

                string output = Convert.ToString((int)amount);
                output += ".";
                int decimals = (int)(((decimal)amount % 1) * 100);
                output += Convert.ToString(decimals);
                if (Convert.ToString(decimals).Length == 1)
                {
                    output += "0";
                }
                

                Console.WriteLine("{0,4}{1, 20:C}", year, output);

            }

            

            Console.ReadKey();

        }
    }
}
