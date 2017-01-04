using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    abstract class Wagon
    {
        protected string Model;
        protected int Masa;
        public abstract string Informacja();
        public int zwracamMase()
        {
            return Masa;
        }

    }
}
