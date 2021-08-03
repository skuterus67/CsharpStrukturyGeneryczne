﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class SlownikTest
    {
        [TestMethod]
        public void UzywamySlownikaJakoMapy()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.AreEqual("jeden", mapa[1]);
        }

        [TestMethod]
        public void WyszukiwanieWSlowniku()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.IsTrue(mapa.ContainsKey(2));
        }

        [TestMethod]
        public void UsuwanieZeSlownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Remove(1);

            Assert.AreEqual(2, mapa.Count);
        }

        [TestMethod]
        public void CzyszczenieSlownika()
        {
            var mapa = new Dictionary<int, string>();
            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Clear();

            Assert.AreEqual(0, mapa.Count);
        }

        [TestMethod]
        public void SlownikJakoSlownik()
        {
            var mapa = new Dictionary<string, string>();
            mapa.Add("one", "jeden");
            mapa.Add("two", "dwa");
            mapa.Add("three", "trzy");

            Assert.AreEqual("jeden", mapa["one"]);
        }

    }
}
