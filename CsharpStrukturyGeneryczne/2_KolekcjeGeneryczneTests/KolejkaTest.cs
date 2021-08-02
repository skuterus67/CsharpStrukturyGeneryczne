using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejkaTest
    {
        [TestMethod]
        public void UzycPeek()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.AreEqual(1, kolejka.Peek());
        }

        [TestMethod]
        public void UzycContains()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void UzycToArray()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            var tab = kolejka.ToArray();
            kolejka.Dequeue();

            Assert.AreEqual(1, tab[0]);
            Assert.AreEqual(3, kolejka.Count);
        }

        [TestMethod]
        public void UzycClear()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            kolejka.Clear();

            Assert.AreEqual(0, kolejka.Count);
        }
    }
}
