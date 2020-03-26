using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    abstract class Figure
    {
        public void ShowInf()
        {
            Console.WriteLine("  Периметр фiгури - " + P);
            Console.WriteLine("  Площа фiгури - " + S);
        }
        abstract public double Cal_P(double x, double y);
        abstract public double Cal_S(double x, double y);

        protected double P;
        protected double S;
    }
}
