using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Rectangle : Figure
    {
        public override double Cal_P( double x, double y)
        {
            P = (2 * x + 2 * y);
            return P;
        }
        public override double Cal_S(double x, double y)
        {
            S = x * y;
            return S;
        }
    }
}
