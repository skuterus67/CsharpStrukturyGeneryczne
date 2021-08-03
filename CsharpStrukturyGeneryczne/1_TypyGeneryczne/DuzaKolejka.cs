﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _1_TypyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka;

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual bool JestPusty => kolejka.Count == 0;

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return kolejka.GetEnumerator();

            foreach (var item in kolejka)
            {
                // filtrowanie

                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}