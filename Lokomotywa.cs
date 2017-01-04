using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    class Lokomotywa
    {
        private string Model;
        private int Masa;
        public Lokomotywa(string Model, int Masa)
        {
            this.Model = Model;
            this.Masa = Masa;
        }
        public int zwracamMase()
        {
            return Masa;
        }
        public string Informacja()
        {
            return "Lokomotywa "+"Masa : " + Masa + ", Model: " + Model;
        }
    }
}
