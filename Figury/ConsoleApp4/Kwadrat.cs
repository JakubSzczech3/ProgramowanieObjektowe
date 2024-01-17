using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Kwadrat : Figura
    {
        double a = 4;
        public override double obwod()
        {
            return 4*a;
        }

        public override double pole()
        {
            return a * a;
        }
    }
}
