using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Circle : Figure
    {
        public override double Cal_P(double r, double pi)
        {
            P = 2 * pi * r;
            return P;
        }
        public override double Cal_S(double r, double pi)
        {
            S = pi*Math.Pow(r,2);
            return S;
        }
    }
}
