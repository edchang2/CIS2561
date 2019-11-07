using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jotd
{
    class Program
    {
        static void Main(string[] args)
        {
            Prefs.Prefs prefs = Prefs.Prefs.GetInstance("config.txt");

            //set language
            if (args.Length > 0)
            {
                prefs.Set("lang", args[0]);
            }

            string lang = prefs.Get("lang");

            string[] jokes = File.ReadAllLines("data//jokes-" + lang + ".txt");

            Random r = new Random();
            Console.WriteLine(jokes[r.Next(jokes.Length) ]);


            prefs.Save();


        }
    }
}
