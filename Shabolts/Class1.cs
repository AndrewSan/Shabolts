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
        abstract public int Cal_P();
        abstract public int Cal_S();

        protected double P;
        protected double S;
    }
}
