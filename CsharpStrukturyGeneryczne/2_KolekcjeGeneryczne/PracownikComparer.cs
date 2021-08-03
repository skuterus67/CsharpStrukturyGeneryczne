using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class PracownikComparer : IEqualityComparer<Pracownik>, IComparer<Pracownik>
    {
        public int Compare(Pracownik x, Pracownik y)
        {
            return String.Compare(x.Nazwisko, y.Nazwisko);
        }

        public bool Equals(Pracownik x, Pracownik y)
        {
            return String.Equals(x.Nazwisko, y.Nazwisko);
        }

        public int GetHashCode(Pracownik obj)
        {
            return obj.Nazwisko.GetHashCode();
        }
    }
}
