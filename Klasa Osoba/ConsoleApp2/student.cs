using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class student:Osoba
    {
        private string nrAlbumu;
        private string kierunek;

        public string NrAlbumu { get { return nrAlbumu; } set { } }
        public string Kierunek { get { return kierunek; } set { } }

        public student(string name, int age, string nrAlbumu, string kierunek):
            base(name, age)
        {
            this.nrAlbumu = nrAlbumu;
            this.kierunek = kierunek;
        }
    }
}
