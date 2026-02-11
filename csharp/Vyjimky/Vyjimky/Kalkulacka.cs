using System;
using System.Collections.Generic;
using System.Text;

namespace Vyjimky
{
    internal class Kalkulacka
    {

        public double Vydel(double a, double b)
        {
            if (b == 0)
                throw new Exception("Nelze delit nulou");
            return a / b;
        }
    }
}
