using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biling
{
    class Telefon:IBiling,IDodaj
    {
        private List<Usluga> biling = new List<Usluga>();

        public void DodajPolaczenie(string numer, int czasP)
        {
            biling.Add(new Polaczenie(DateTime.Now ,numer,czasP));
        }

        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now,numer));
           
        }
        
        public void DodajInternet(int iloscMB)
        {
            biling.Add(new Internet(DateTime.Now,iloscMB));

        }

        override public String ToString()
        {
            string s ="";

            foreach(var item in biling)
            { 
                s+=item.ToString()+Environment.NewLine;
            }
            return s;
        }

        public void ZapiszBiling(){
            StreamWriter plik = new StreamWriter("@../../biling.txt");
            plik.Write(this.ToString());
            plik.Close();
        }
    }
}
