using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Pole prostokata: "+Width*Height);
        }
    }
}
