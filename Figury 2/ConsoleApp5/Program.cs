using ConsoleApp5;
using DocumentFormat.OpenXml.Drawing.Charts;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape> {
            new Rectangle { X = 0, Y = 0, Height = 5, Width = 10 },
            new Triangle { X = 1, Y = 1, Height = 6, Width = 12 },
            new Circle { X = 4,}

            };

            foreach (var shape in shapes) {
                shape.Draw();
            }

        }
    }
}
