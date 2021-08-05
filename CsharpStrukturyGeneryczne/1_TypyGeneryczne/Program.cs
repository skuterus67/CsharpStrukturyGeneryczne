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
            //Action<double> drukuj = d => Console.WriteLine(d);
            //Action<bool> drukujB = d => Console.WriteLine(d);

            //Func<double, double> potegowanie = d => d * d;
            //Func<double, double, double> dodaj = (x, y) => x + y;

            //Predicate<double> jestMniejszeOdSto = d => d < 100;

            //drukujB(jestMniejszeOdSto(potegowanie(dodaj(6, 8))));

            var kolejka = new KolejkaKolowa<double>();
            WprowadzanieDanych(kolejka);

            //Converter<double, DateTime> konwerter = d => new DateTime(2018, 1, 1).AddDays(d);
            var jakoData = kolejka.Mapuj(d => new DateTime(2018, 1, 1).AddDays(d));

            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }
            
            //kolejka.Drukuj(drukuj);

            //var elementyJakoInt = kolejka.ElementJako<double, int>();

            //foreach (var item in elementyJakoInt)
            //{
            //    Console.WriteLine(item);
            //}

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

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("w naszej kolejce jest: ");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
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
