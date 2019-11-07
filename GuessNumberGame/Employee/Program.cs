using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private String first;
        private String last;
        private double salary;

        public String getFirst()
        {
            return first;
        }

        public String getLast()
        {
            return last;
        }

        public double getSalary()
        {
            return salary;
        }

        public void setFirst(String name)
        {
            first = name;
        }

        public void setLast(String name)
        {
            last = name;
        }

        public Employee(String firstName, String lastName, double amount)
        {
            first = firstName;
            last = lastName;
            salary = amount;
        }

        public void setSalary(double amount)
        {
            if (amount > 0)
            {
                salary = amount;
            }
        }

        public void raise(double percentage)
        {
            double amount = salary * percentage;
            salary += amount;

        }

        static void Main(string[] args)
        {
            //initialize
            Employee Matthew = new Employee("Matthew", "Park", 100);
            Employee Emily = new Employee("Emily", "Dickinson", 150);

            //print salary
            Console.WriteLine(Matthew.getFirst() + "'s salary is $" + Matthew.getSalary());
            Console.WriteLine(Emily.getFirst() + "'s salary is $" + Emily.getSalary());

            Console.WriteLine("Raise time");
            Matthew.raise(.10);
            Emily.raise(.10);

            Console.WriteLine(Matthew.getFirst() + "'s new salary is $" + Matthew.getSalary());
            Console.WriteLine(Emily.getFirst() + "'s new salary is $" + Emily.getSalary());

            Console.ReadKey();

        }
    }
}
