using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
	class Program
	{
		static void Main(string[] args)
		{
            /*LISTA*/
            List<Pracownik> pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
            };

            pracownicy.Add(new Pracownik { Imie = "Anna", Nazwisko = "Kos" });

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            for (int i = 0; i < pracownicy.Count; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            //var liczby = new List<int>();
            //var pojemnosc = -1;

            //while (true)
            //{
            //	if (liczby.Capacity != pojemnosc)
            //             {
            //		pojemnosc = liczby.Capacity;
            //		Console.WriteLine(liczby.Capacity);
            //             }
            //	liczby.Add(1);

            //}

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*KOLEJKA*/
            Queue<Pracownik> kolejka = new Queue<Pracownik>();

			kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.WriteLine("*******************************");

        }
	}
}
