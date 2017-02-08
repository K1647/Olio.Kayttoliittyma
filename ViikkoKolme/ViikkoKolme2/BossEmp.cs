using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoKolme2
{
    class Person
    {
        public string Name { get; set; }
        public string Professio { get; set; }
        public int Salary { get; set; }
        // default constructor
        public Person()
        {
        }

        // constructor takes person name, profession and salary as a parameter
        public Person(string name, string profession, int salary)
        {
            Name = name;
            Professio = profession;
            Salary = salary;
        }

        // just one method what Person can do
        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Name + " " + Professio + " " + Salary;
        }
    }
    class Employee : Person
    {
        public Employee()
        {
        }
        public Employee(string name, string profession, int salary)
            : base(name, profession, salary)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " ";
        }

    }
    class Boss : Person
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        // default constructor
        public Boss()
            {
            }

            // parametric constuctor calls base class constructor with parameters
            public Boss(string name, string profession, int salary, string car, int bonus)
                : base(name, profession, salary)
            {
                Car = car;
                Bonus = bonus;
            }

            // just one method what Teacher can do 
            public void BossMethod()
            {
                Console.WriteLine("This method belongs to Boss!");
            }

            // override base class ToString()-method
            public override string ToString()
            {
                return base.ToString() + " " + Car + " " + Bonus;
            }
    }
}
