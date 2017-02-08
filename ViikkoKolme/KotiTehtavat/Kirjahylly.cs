using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat
{
    class Kirjahylly
    {
      
        public string Name { get; set; }
        public string Type { get; set; }
        public int Manufactured { get; set; }
        // default constructor
        public Kirjahylly()
        {
        }

        // constructor takes person name, profession and salary as a parameter
        public Kirjahylly(string name, string type, int manufactured)
        {
            Name = name;
            Type = type;
            Manufactured = manufactured;
        }
       

        // return Kirjahylly data as a one string, override Object class ToString()-method
        public override string ToString()
            {
                return Name + " " + Type + " " + Manufactured;
            }
    }
    class Book : Kirjahylly
    {
        public string Genre { get; set; }
        public int Bonus { get; set; }

        // default constructor
        public Book()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Book(string name, string type, int manufactured, string genre)
                : base(name, type, manufactured)
        {
            Genre = genre;
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Genre;
        }
    }
    class Disc : Kirjahylly
    {
        public string Genre { get; set; }
        public int Lenght { get; set; }

        // default constructor
        public Disc()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Disc(string name, string type, int manufactured, string genre, int lenght)
                : base(name, type, manufactured)
        {
            Genre = genre;
            Lenght = lenght;
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Genre + " " + Lenght + "min";
        }
    }
    class Electronic : Kirjahylly
    {
        public string OS { get; set; }
        public string Manufacturer { get; set; }

        // default constructor
        public Electronic()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Electronic(string name, string type, int manufactured, string os, string manufacturor)
                : base(name, type, manufactured)
        {
            OS = os;
            Manufacturer = manufacturor;
        }


        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + OS + " " + Manufacturer;
        }
    }
}
