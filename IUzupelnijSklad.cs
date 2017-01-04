using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    interface IUzupelnijSklad
    {
        void DodajOsobowy(int Masa, string Model, string Rodzaj);
        void DodajTowarowy(int Masa, string Model, string Ladunek);
        void DodajLokomotywe(int Masa, string Model);
    }
}
