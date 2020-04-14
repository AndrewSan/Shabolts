using System;
using System.Collections.Generic;
using System.Text;

namespace Qurantine_is_hell
{
    class Mocik
    {
        private string _marka;
        private double _price;
        private double _maxV;

        public Mocik()
        {
            _marka = "  SlaV";
            _price = 31415;
            _maxV = 271;
        }

        public Mocik(string marka, double price, double maxV)
        {
            _marka = marka;
            _price = price;
            _maxV = maxV;
        }

        public void GetInformation()
        {
            Console.Write("  Марка моцика - ");
            _marka = Convert.ToString(Console.ReadLine());
            Console.Write("  Цiна того моцика - ");
            _price = Convert.ToDouble(Console.ReadLine());
            Console.Write("  Скiльки моцик саме бiльше поїде - ");
            _maxV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format(" Mocik Marka = {0}, Price = {1}, MaxSpeed = {2}", _marka, _price, _maxV);
        }
    }
}
