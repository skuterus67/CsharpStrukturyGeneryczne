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
            Console.WriteLine("LISTA");
            Lista();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*KOLEJKA*/
            Console.WriteLine("KOLEJKA");
            Kolejka();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*STOS*/
            Console.WriteLine("STOS");
            Stos();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*HASHSET*/
            Console.WriteLine("HASHSET");
            HashSet();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*LINKEDLIST*/
            Console.WriteLine("LINKEDLIST");
            LinkedList();

            Console.WriteLine("*******************************");
            LinkedList2();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*SLOWNIK*/
            Console.WriteLine("SLOWNIK");
            Slownik();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*SLOWNIK SORTOWANY*/
            Console.WriteLine("SLOWNIK SORTOWANY");
            SortedDictionary();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*LISTA SORTOWANA*/
            Console.WriteLine("LISTA SORTOWANA");
            SortedList();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*ZBIOR SORTOWANY*/
            Console.WriteLine("ZBIOR SORTOWANY");
            SortedSet();

            Console.WriteLine("*******************************");
            /***************************************************************************/
            /*POROWNYWANIE PRACOWNIKOW*/
            Console.WriteLine("POROWNYWANIE PRACOWNIKOW");
            var pracownicy = new SortedDictionary<string, SortedSet<Pracownik>>();

            pracownicy.Add("Ksiegowosc", new SortedSet<Pracownik>(new PracownikComparer()));

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kowal" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kaczor" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Bogacki" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Sprzedaz", new SortedSet<Pracownik>(new PracownikComparer()));

            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Glowacki" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Czapla" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Nowak" });

            foreach (var dzial in pracownicy)
            {
                Console.WriteLine(dzial.Key);
                foreach (var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);
                }
            }
        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();
            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*******************************");
            var set2 = new SortedSet<string>();
            set2.Add("tomek");
            set2.Add("iza");
            set2.Add("ola");
            set2.Add("ala");
            set2.Add("piotr");
            set2.Add("beata");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");
            listaPosortowana.Add(2, "dwa");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>();

            pracownicy.Add("Sprzedaz", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" },
                                                             new Pracownik { Imie = "Marcin", Nazwisko = "Bien" }});
            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Marcin", Nazwisko = "Kowal"},
                                                                new Pracownik { Imie = "Tomek", Nazwisko = "Wrobel" }});
            pracownicy.Add("Ksiegowosc", new List<Pracownik> { new Pracownik { Imie = "Olek", Nazwisko = "Kowalski" },
                                                               new Pracownik { Imie = "Bartek", Nazwisko = "Nawrocko" },
                                                               new Pracownik { Imie = "Jurek", Nazwisko = "Pytel" },
                                                               new Pracownik { Imie = "Robert", Nazwisko = "Stach" }});

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilosc pracownikow w dziale {0} wynosi {1}", item.Key, item.Value.Count);
            }
        }

        private static void Slownik()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Kowal"},
                                                                 new Pracownik { Nazwisko = "Kaczor"} });

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski" },
                                                                  new Pracownik { Nazwisko = "Bogacki" } });
            //var kowal = pracownicy["Kowal"];

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział: " + item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pracownicy z ksiegowosci:");
            foreach (var pracownik in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(pracownik.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;

            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();

            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Jan", Nazwisko = "Nowak" };
            set.Add(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            set.Add(pracownik);
            set.Add(pracownik);

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();

            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Jan", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
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
        }

        private static void Lista()
        {
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
        }
    }
}
