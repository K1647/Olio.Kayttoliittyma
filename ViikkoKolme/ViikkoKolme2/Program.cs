using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoKolme2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestElevator();
            //TestVolume();
            //TestPersons();
            TestVehicle();
            
        }
        public static void TestElevator()
        {
            Hissi elevator = new Hissi();
            while (true)
            {
                
                // ask number from the user (read one line)
                Console.Write("Give a floor number > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                int number;
                bool result = Int32.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    elevator.Kerros = number;
                    Console.WriteLine("Elevator is now in floor : " + elevator.Kerros);
                }
                else break;
            } 
        }
        public static void TestVolume()
        {
            Vahvistin mankka = new Vahvistin();
            while (true)
            {

                // ask number from the user (read one line)
                Console.Write("Give a new volume value (0-100) > ");
                string line = Console.ReadLine();
                // try to read number from the given line
                int number;
                bool result = Int32.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    mankka.Voluumi = number;
                    Console.WriteLine("-> Amplifier volume is set to : " + mankka.Voluumi);
                }
                else break;
            }
        }
        public static void TestPersons()
        {
            Employee employee = new Employee("Kirsi Kernel", "Teacher", 1200);
            Console.WriteLine(employee.ToString());
            Boss boss = new Boss("Jussi Jurkka", "Head of Institute", 9000, "Audi", 5000);
            Console.WriteLine(boss.ToString());
            employee.Professio = "Principl";
            employee.Salary = 2200;
            Console.WriteLine(employee.ToString());
        }
        public static void TestVehicle()
        {
            Bicycle jopo = new Bicycle("Jopo", "Street", 2016, "Blue", false, " ");
            Console.WriteLine(jopo.ToString());
            Bicycle tunturi = new Bicycle("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Console.WriteLine(tunturi.ToString());
            Boat suvi = new Boat("Suvi", "S900", 1990, "White", 3, "Rowboat");
            Console.WriteLine(suvi.ToString());
            Boat yamaha = new Boat("Yamaha", "Model 1000", 2010, "Yellow", 5, "Motorboat");
            Console.WriteLine(yamaha.ToString());
        }
    }
}
