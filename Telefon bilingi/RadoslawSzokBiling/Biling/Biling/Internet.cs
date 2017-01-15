using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling
{
    class Internet:Usluga
    {
        int iloscMB;

        void ObliczCene()
        {
            cena = iloscMB / 756;
        }

        public Internet(DateTime t, int i)
        {
            this.czas = t;
            this.iloscMB = i;
            ObliczCene();
        }
        override public String ToString()
        {
            return "INTERNET DATA: " + czas + " ILOSC MB: " + cena+ " LACZNY KOSZT: " + cena;
        }
    }
}
