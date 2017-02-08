using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    //tehtävä 6
    class Tietokone
    {
        public bool OnkoVirta { get; set; }
        public bool OnkoNetti { get; set; }
        public string Name { get; set; }
        public string CpuInfo { get; set; }
        public string GpuInfo { get; set; }
        public override string ToString()
        {
            return "Virta: " + OnkoVirta + " | Nettiyhteys: " + OnkoNetti + " | Valmistaja: " + Name + " | CPU: " + CpuInfo + " | GPU: " + GpuInfo;
        }
        public Tietokone(bool virta, bool netti, string nimi, string cpu, string gpu)
        {
            OnkoVirta = virta;
            OnkoNetti = netti;
            Name = nimi;
            CpuInfo = cpu;
            GpuInfo = gpu;
        }
       
        public void PrintData()
        {
            Console.WriteLine(ToString());
        }
         
    }
}
