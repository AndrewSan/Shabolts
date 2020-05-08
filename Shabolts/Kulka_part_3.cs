using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kulka
    {
        public Kulka()
        {
            r = 2.71;
        }
        private double pi = 3.14;
        private double r;
        public double Dlinna(double r)
        {
            Console.Write("  Длинна круга - " + (r * 2 * pi));
            return (r * 2 * pi);
        }
        public double Plosha(double r)
        { 
            Console.Write("  Площадь круга - " + (Math.Pow(r, 2) * pi));
            return Math.Pow(r,2) * pi;
        }
        public double Amount(double r)
        {
            Console.Write("  Объем шарика - " + ((4 / 3) * Math.Pow(r, 3) * pi));
            return (4/3) * Math.Pow(r, 3) * pi;
        }
    }
}
