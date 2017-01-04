using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PociagConsole
{
    class Aplikacja:Pociag
    {
        public Aplikacja() 
        {
            WypiszInfo();
            Operacje();
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Aplikacja do skladania pociagow");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("L - dodaj lokomotywe");
            Console.WriteLine("W - dodaj wagon");
            Console.WriteLine("Z - wypisz zawartosc");
            Console.WriteLine("S - sprawdz czy moze jechac");
            Console.WriteLine("E - wyjscie");
        }
        public void wybierzWagon()
        {
            string Model, Ladunek,Rodzaj;
            int Masa;
            Console.WriteLine("Wybierz rodzaj wagonu");
            Console.WriteLine("T - towarowy");
            Console.WriteLine("O - osobowy");
            Console.WriteLine("B - powrot do Menu glownego");
            char znak;
            znak = Convert.ToChar(Console.ReadLine());
            try
            {
                if (znak == 'T')
                {
                    Console.WriteLine("Podaj mase ");
                    Masa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj model");
                    Model = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Podaj ladunek");
                    Ladunek = Convert.ToString(Console.ReadLine());
                    DodajTowarowy(Masa, Model, Ladunek);
                    Console.WriteLine("Dodano WAGON");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();

                }
                else if (znak == 'O')
                {
                    Console.WriteLine("Podaj mase ");
                    Masa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj model");
                    Model = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Podaj rodzaj");
                    Rodzaj = Convert.ToString(Console.ReadLine());
                    DodajTowarowy(Masa, Model, Rodzaj);
                    Console.WriteLine("Dodano WAGON");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                }
                else if(znak=='B')
                {
                    WypiszInfo();
                    Operacje();
                }
                else
                {
                    Console.WriteLine("Wybrales niewlasciwy znak");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            WypiszInfo();
            Operacje();

        }
        public void Operacje()
        {
            char Znak;
            Znak = Convert.ToChar(Console.ReadLine());
            try
            {
              switch(Znak)
              {
                case 'L':
                      string Model;
                      int Masa;
                      Console.WriteLine("Podaj Model");
                      Model = Convert.ToString(Console.ReadLine());
                      Console.WriteLine("Podaj Mase");
                      Masa = Convert.ToInt32(Console.ReadLine());
                      DodajLokomotywe(Masa,Model);
                      Console.WriteLine("Dodano lokomotywe");
                      System.Threading.Thread.Sleep(200);
                      Console.Clear();
                      WypiszInfo();
                      Operacje();
                    break;
                case 'W':
                    wybierzWagon();
                    break;
                case 'Z':
                    Informacje();
                    Console.ReadKey();
                    WypiszInfo();
                    Operacje();
                    break;
                case 'S':
                    MozeJechac();
                    break;
                case 'E':
                    Console.WriteLine("Do zobaczenia !");
                    break;
                  default:
                    Console.WriteLine("Wpisales nie prawidlowy klawisz");
                    break;
              }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
        }

    }
}
