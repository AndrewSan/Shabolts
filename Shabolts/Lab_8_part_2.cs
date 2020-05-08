using System;
using System.IO;

class Program
{
    static void ReadFile(string q, Action<string> w)
    {
        w(q);
    }

    static void Show(string bufer)
    {
        Console.WriteLine("  Вместимое файла:");
        Console.WriteLine("  " + bufer);
    }

    static void Zamena(string w)
    {
        w = w.Replace(',', ' ');
        w = w.Replace('.', ' ');
        w = w.Replace('(', ' ');
        w = w.Replace(')', ' ');
        w = w.Replace('*', ' ');

        Console.WriteLine("  " + w);
    }


    static void Main(string[] args)
    {
        StreamReader bufer = new StreamReader("C:\\Users\\USER ONE\\Desktop\\Корзина\\Programming\\Hui\\ConsoleApp1\\part1.txt");
        string data;
        data = Convert.ToString(bufer.ReadToEnd());

        Action<string> w = Show;
        ReadFile(data, w);

        w = Zamena;
        Console.WriteLine("  После замены:");
        ReadFile(data, w);
    }
}
