using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoKolme2
{

    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }
        // default constructor
        public Vehicle()
        {
        }

        // constructor takes person name, profession and salary as a parameter
        public Vehicle(string name, string model, int modelyear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
            Color = color;
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Name + " " + Model + " " + ModelYear + " " + Color;
        }
    }
    class Bicycle : Vehicle
    {
        string vaihteisto;
        public bool GearWheels { get; set; }
        public string GearName
        {
            get
            {
                return vaihteisto;
            }
            set
            {
                if (GearWheels == true)
                {
                    vaihteisto = value;
                }
                else
                {
                    vaihteisto = "";
                }
            }
        }
        public Bicycle()
        {
        }
        public Bicycle(string name, string model, int modelyear, string color, bool onkoVaihteet, string vaihdeNimi) 
            : base(name,model,modelyear,color)
        {
            GearWheels = onkoVaihteet;
            GearName = vaihdeNimi;
        }

        public override string ToString()
        {
            return base.ToString() + " " + GearWheels + " " + GearName;
        }


    }
    class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }
        public Boat()
        {
        }
        public Boat(string name, string model, int modelyear, string color, int penkkicount, string venetype)
            : base(name, model, modelyear, color)
        {
            SeatCount = penkkicount;
            BoatType = venetype;
        }

        public override string ToString()
        {
            return base.ToString() + " " + SeatCount + " " + BoatType;
        }


    }
}
