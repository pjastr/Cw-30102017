using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
            //:base(imie, nazwisko, rokUrodzenia)
        {
            this.numerAlbumu = numerAlbumu;
            this.numerGrupy = numerGrupy;
            this.rok = rok;
            this.imie = imie;
            this.nazwisko=nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            
        }

        public void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }
    }
}
