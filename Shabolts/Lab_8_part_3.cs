using ConsoleApp1;
using System;
using System.IO;

class Program
{
    delegate double Del(double w);
    static void Main(string[] args)
    {
        Kulka buf = new Kulka();
        Del del = buf.Dlinna;
        del(2.71);
        del = buf.Plosha;
        del(2.71);
        del = buf.Amount;
        del(2.71);
    }
}
