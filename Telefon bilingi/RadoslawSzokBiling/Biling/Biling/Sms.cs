using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling
{
    class Sms:Usluga
    {
        private string numer;

        void ObliczCena()
        {
            cena = 0.15;
        }

        public Sms(DateTime t, string s)
        {
            this.czas = t;
            this.numer = s;
            ObliczCena();
        }

        override public String ToString()
        {
            return "SMS " + numer + " DATA: " + czas + " LACZNY KOSZT: " + cena;
        }
    }
}
