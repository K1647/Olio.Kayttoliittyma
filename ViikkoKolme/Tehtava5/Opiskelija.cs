using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Opiskelija
    {
        public string Name { get; set; }
        public string Education { get; set; }
        public string Class { get; set; }
        int ikä;
        public int Age
        {
            get { return ikä; }
            set
            {
                if (value < 0)
                {
                    ikä = 0;
                }
                else if (value > 100)
                {
                    ikä = 100;
                }
                else
                {
                    ikä = value;
                }
            }
        }
        public Opiskelija(string nimi)
        {
            Name = nimi;
        }
    }
}
