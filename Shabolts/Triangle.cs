using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Triangle : Figure
    {
        public override double Cal_P(double a, double b)
        {
            P = a + b;
            return P;
        }
        public override double Cal_S(double a, double h)
        {
            S = 0.5*h*a;
            return S;
        }

        //public double CalPerimetr(double a, double b, double c)
        //{
        //    P = a + b + c;
        //    return P;
        //}
    }
}
