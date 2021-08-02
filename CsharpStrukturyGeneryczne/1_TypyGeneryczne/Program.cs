using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
	class Program
	{
		static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);

            //var kolejkaInt = new KolejkaKolowa<int>();
            //var kolejkaString = new KolejkaKolowa<string>(1000);

            //var kolejkaOsob = new KolejkaKolowa<Osoba>();
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Marcin", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Tomek", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Jacek", Nazwisko = "Nowak" });
            //kolejkaOsob.Zapisz(new Osoba { Imie = "Marek", Nazwisko = "Inny" });

            //while (!kolejkaOsob.JestPusty)
            //{
            //	var wynik = kolejkaOsob.Czytaj().Imie;
            //	Console.WriteLine(wynik);
            //}


        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("w naszej kolejce jest: ");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }

	//public class Osoba
 //   {
	//	public string Imie { get; set; }

	//	public string Nazwisko { get; set; }
 //   }
}
