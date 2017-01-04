using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    class Osobowy:Wagon
    {
        private string Rodzaj;
        public Osobowy(string Model,int Masa,string Rodzaj)
        {
            this.Model = Model;
            this.Masa = Masa;
            this.Rodzaj = Rodzaj;
        }
        public override string Informacja()
        {
            return "Lokomotywa "+"Masa : " + Masa + ", Model: " + Model+"Rodzaj: "+Rodzaj;
        }
    }
}
