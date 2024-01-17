using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Szescian: Figura3D
    {
        double a = 6;
        public void objetosc() {

            Console.WriteLine("Objętosc "+a*a*a);
        }
        public void pole() {

            Console.WriteLine("Pole "+a*12);
        
        }

    }
}
