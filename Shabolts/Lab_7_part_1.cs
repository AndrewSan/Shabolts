using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            StreamReader buf = new StreamReader("C:\\Users\\USER ONE\\Desktop\\Корзина\\Programming\\Hui\\ConsoleApp1\\text_part1.txt");
            string data;
            int countOpen = 0, countClose = 0;
            data = Convert.ToString(buf.ReadToEnd());

            for(int i =0; i< data.Length; i++)
            {
                if (data[i] == '(')
                    countOpen++;
                else if (data[i] == ')')
                    countClose++;
            }

            if (countClose == countOpen)
                Console.WriteLine("  Normas");
            else
                Console.WriteLine("  NE normas");

            Console.WriteLine(data);
        }
    }
}


    
