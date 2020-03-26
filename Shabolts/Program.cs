using System;
using System.IO;

namespace Shabolts
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "", bufer;
            using (StreamReader MyFile = new StreamReader("C:\\Users\\USER ONE\\Desktop\\Корзина\\Programming\\Shabolts\\Shabolts\\test.txt"))
            {
                while ((bufer = MyFile.ReadLine()) != null)
                {
                    stroka += bufer;
                }
            }



            
        }
    }
}