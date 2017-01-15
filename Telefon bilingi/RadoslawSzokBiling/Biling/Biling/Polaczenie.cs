using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling
{
    class Polaczenie : Usluga
    {
        private string numer;
        private int czasP;

        void ObliczCene()
        {
            cena=czasP*0.29;
        }

        public Polaczenie(DateTime t, string s, int i)
        {
            this.czas = t;
            this.numer = s;
            this.czasP = i;
            ObliczCene();
        }

        override public String ToString()
        {
            return "SMS " + numer + " DATA: " + czas + " DLUGOSC TRWANIA: " + czasP + " LACZNY KOSZT: " + cena;
        }
    }
}
