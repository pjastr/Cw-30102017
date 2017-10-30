using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Ksiegarnia
    {
        private int ileKsiazek;
        private string adres;
        private bool dlaDzieci;

        public Ksiegarnia(int ileKsiazek, string adres, bool dlaDzieci)
        {
            this.ileKsiazek = ileKsiazek;
            this.adres = adres;
            this.dlaDzieci = dlaDzieci;
        }
    }
}
