using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Osoba
    {
        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        private string nazwisko;

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        //public Osoba(string imie, string nazwisko)
        //{
        //    this.imie = imie;
        //    this.nazwisko = nazwisko;
        //}
    }

    class Pacjent : Osoba
    {
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek)
            
        {
            this.wiek = wiek;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }
    }
}
