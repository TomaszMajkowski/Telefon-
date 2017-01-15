using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biling
{
    abstract class Usluga
    {
        protected DateTime czas;
        protected double cena;

        void ObliczCene()
        {

        }
        public Usluga()
        {

        }
        public Usluga(DateTime czas)
        {
            this.czas = czas;
        }

    }
}
