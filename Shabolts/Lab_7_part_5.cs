using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        const int N = 1990;
        static void Main()
        {
            int bufer;
            List<int> masivchik = new List<int>();
            Random rand = new Random();

            for(int i =0; i<N;i++)                               // Task #1
            {
                masivchik.Add(rand.Next(200, 400+1));
            }

            masivchik.Sort();                                   // Task #2

            masivchik[11] = 11;                                 // Task #4

            Console.WriteLine("  Елементы масивчика:");
            foreach( int w in masivchik)                        // Task #3
            {
                Console.Write(w + " ");
            }
            Console.WriteLine();


            bufer = rand.Next(0, 1011);
            Console.WriteLine("  Загаданое число - " + bufer);  // Task #5
            for (int i=0; i <N; i++)
            {
                if (masivchik[i] == bufer)
                    Console.WriteLine("  Найдено совпадение, а вот и индекс елемента - " + i);
            }

            Console.WriteLine("  Загаданый индекс - " + bufer);  // Task #5
            bufer = rand.Next(0, N);
            masivchik.Remove(bufer);

            masivchik.Clear();
            Console.Write("  Елементы масивчика:");
            foreach (int w in masivchik)                        // Task #6
            {
                Console.Write(w + " ");
            }
            Console.WriteLine("  А нету");
        }
    }
}




