using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    class Towarowy:Wagon
    {
        private string Ladunek;
        public Towarowy(string Model,int Masa,string Ladunek)
        {
            this.Model = Model;
            this.Masa = Masa;
            this.Ladunek = Ladunek;
        }
        public override string Informacja()
        {
            return "Lokomotywa " + "Masa : " + Masa + ", Model: " + Model + "Ladunek: " + Ladunek;
        }
    }
}
