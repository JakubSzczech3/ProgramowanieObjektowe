using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Circle : Shape
    {
        public override void Draw()
        {
            double z = 0.5 * X;
            double pole = z*z*Math.PI;
            Console.WriteLine("Pole kola wynosi: "+ pole);
            
        }
    }
}
