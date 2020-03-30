using System;
using System.IO;

namespace Shabolts
{
    class Program
    {
        const int N = 6;
        const double pi = 3.14;
        static void Main(string[] args)
        {
            double[] buferMas = new double[N];
            using (StreamReader MyFile = new StreamReader("C:\\Users\\USER ONE\\Desktop\\Корзина\\Programming\\Shabolts\\Shabolts\\test.txt"))
            {
               for(int i = 0; i<N;i++)
               {
                    buferMas[i] = Convert.ToInt32(MyFile.ReadLine());
               }
            }

            Figure[] masiv = new Figure[3];

            masiv[0] = new Rectangle();
            masiv[1] = new Circle();
            masiv[2] = new Triangle();

            Console.WriteLine("  Прямокутник");
            masiv[0].Cal_P(buferMas[0], buferMas[1]);
            masiv[0].Cal_S(buferMas[0], buferMas[1]);
            masiv[0].ShowInf();
            Console.WriteLine();Console.WriteLine();


            Console.WriteLine("  Коло");
            masiv[1].Cal_P(buferMas[2], pi);
            masiv[1].Cal_S(buferMas[2], pi);
            masiv[1].ShowInf();
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("  Трикутник");
            masiv[2].Cal_P(buferMas[3], buferMas[4]);
            masiv[2].Cal_S(buferMas[3], buferMas[5]);
            masiv[2].ShowInf();
        }
    }
}