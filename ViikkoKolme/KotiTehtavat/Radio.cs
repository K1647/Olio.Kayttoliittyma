using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat
{
    class Radio
    {
        int voltaso;
        string onoff;
        double taajuus;
        public double Taajuus
        {
            get { return taajuus; }
            set
            {

                if (value < 2000.0)
                {
                    taajuus = 2000.0;
                }
                else if (value > 2600.0)
                {
                    taajuus = 2600.0;
                }
                else
                {
                    taajuus = value;
                }
            }
        }
        public int Voluumi
        {
            get { return voltaso; }
            set
            {

                if (value < 0)
                {
                    voltaso = 0;
                }
                else if (value > 9)
                {
                    voltaso = 9;
                }
                else
                {
                    voltaso = value;
                }
            }
        }
        public string OnkoPaalla
        {
            get { return onoff; }
            set
            {
                bool result = value.Equals("on", StringComparison.Ordinal);
                if (result == true)
                {
                    onoff = "päällä";
                }
                else
                {
                    onoff = "ei päällä tai väänsit väärää nuppia!";
                }
            }
        }
    }
}
