using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PociagConsole
{
    class Pociag:IPoprawnyPociag,IUzupelnijSklad
    {
        private List<Wagon> Wagony;
        private List<Lokomotywa> Lokomotywy;
        public Pociag() 
        {
            Wagony = new List<Wagon>();
            Lokomotywy = new List<Lokomotywa>();
        }
        public void DodajOsobowy(int Masa,string Model,string Rodzaj)
        {
            Wagony.Add(new Osobowy(Model, Masa, Rodzaj));

        }
        public void DodajLokomotywe(int Masa, string Model)
        {
            Lokomotywy.Add(new Lokomotywa(Model, Masa));
        }
        public string Informacje()
        {
            if(Lokomotywy.Count==0 && Wagony.Count==0)
            {
                Console.WriteLine("Nie ma zadnej lokomotywy i wagonu");
            }
            else if(Lokomotywy.Count==0)
            {
                Console.WriteLine("Nie ma zadnej lokomotwy");
            }
            else if(Wagony.Count==0)
            {
                Console.WriteLine("Nie ma zadnego wagonu");
            }
            else
            {

            Console.WriteLine("Sklad pociagu");
            foreach(var element in Lokomotywy)
            {
                Console.WriteLine("Lokomotywa : {0}",element.Informacja());
               
            }
            foreach(var element in Wagony)
            {
                Console.WriteLine("Wagon : {0}" ,element.Informacja());
            }

            }
            return "";
            

        }
        public void DodajTowarowy(int Masa, string Model, string Ladunek)
        {
            Wagony.Add(new Towarowy(Model,Masa,Ladunek));
        }
        public bool MozeJechac()
        {
            int MasaLokomotyw = 0;
            int MasaWagonow = 0;
            foreach(var element in Lokomotywy)
            {
                MasaLokomotyw = MasaLokomotyw + element.zwracamMase();
            }
            foreach(var element in Wagony)
            {
                MasaWagonow = MasaWagonow + element.zwracamMase();
            }
           
            if (MasaLokomotyw == 0 && MasaWagonow == 0)
            {
                Console.WriteLine("SKlad nie moze jechac");
                return false;
            }
            else if (MasaLokomotyw >= MasaWagonow)
            {
                Console.WriteLine("Sklad moze jechac");
                return true;
            }
            else
                return false;
        }
    }
}
