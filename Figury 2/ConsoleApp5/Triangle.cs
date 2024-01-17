using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Pole trojkata: "+(Width*Height)*0.5);
        }
    }
}
