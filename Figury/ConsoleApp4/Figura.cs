using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    abstract class Figura
    {
        public abstract double pole();
        public abstract double obwod();

        public void view() {
            Console.WriteLine("Klasa abstrakcyjna metoda zwykla");
        }

    }
}
