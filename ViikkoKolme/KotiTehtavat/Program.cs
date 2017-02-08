using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaRadio();
            TestaaKirjahylly();
        }

        public static void TestaaRadio()
        {
            Radio mankka = new Radio();

            while (true)
            {
                Console.Write("Radio to on or off? (write on or off) > ");
                string line2 = Console.ReadLine();
                mankka.OnkoPaalla = line2;
                // ask on or off

                Console.Write("Give a new volume value (0-9) > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                int number;
                bool result = Int32.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    mankka.Voluumi = number;
                }
                else break;

                Console.Write("Give a new frequency value (2000,0-2600,0) > ");
                string line3 = Console.ReadLine();
                // try to read number from the given line
                double number2;
                bool result2 = Double.TryParse(line3, out number2);
                //number2 = Convert.ToDouble(line3);
                // number (integer) was given correctly, use it..
                if (result2)
                {
                    mankka.Taajuus = number2;
                }
                else break;
                Console.WriteLine("\n-> Radio is set to : " + mankka.OnkoPaalla + "\n");
                Console.WriteLine("\n-> Radio's volume is set to : " + mankka.Voluumi + "\n");
                Console.WriteLine("\n-> Radio's frequency is set to : " + mankka.Taajuus + "   Paina lopettaaksesi [ENTER]!\n");
            }
            


        }
        public static void TestaaKirjahylly()
        {
            Book akuankka = new Book("Aku Ankka Taskukirja 666", "Sarjakuva", 2016, "Sarjakuvakirja");
            Console.WriteLine(akuankka.ToString());
            Disc hajyt  = new Disc("Häjyt", "DVD", 1999, "Draama", 105);
            Console.WriteLine(hajyt.ToString());
            Disc stamina = new Disc("Stam1na: Elokuutio", "CD", 2016, "Metalli", 48);
            Console.WriteLine(stamina.ToString());
            Electronic iphone = new Electronic("iPhone 5S", "Älypuhelin", 2013, "iOS", "Apple");
            Console.WriteLine(iphone.ToString());
            Electronic ipad = new Electronic("iPad Air", "Tabletti", 2013, "iOS", "Apple");
            Console.WriteLine(ipad.ToString());
        }
    }
}
