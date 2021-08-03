using System.Collections.Generic;

namespace _1_TypyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        Queue<T> kolejka;

        public DuzaKolejka(int pojemnosc)
        {
            kolejka = new Queue<T>();
        }

        public bool JestPelny => throw new System.NotImplementedException();

        public bool JestPusty => kolejka.Count == 0;

        public T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }
    }
}