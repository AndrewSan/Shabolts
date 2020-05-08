using System;

static class MatrixExt
{
    // метод расширения для получения количества строк матрицы
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(0) + 1;
    }

    // метод расширения для получения количества столбцов матрицы
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetUpperBound(1) + 1;
    }
}

class Program
{
    static void MethodAct(int[,] arr, Action<int [,]> act)
    {
        //foreach (int i in arr)
        //{
            act(arr);
        //}
    }

    static void MethodFunc(int[,] arr, Func<int [,], int [,]> func)
    {
        func(arr);
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        arr[i, j] = func(arr[i, j]);
        //    }
        //}
    }

    static void Show(int [,] num)
    {
        for (var i = 0; i < num.RowsCount(); i++)
        {
            for (var j = 0; j < num.ColumnsCount(); j++)
            {
                Console.Write(num[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static void ShowPositive(int [,] num)
    {
        for (var i = 0; i < num.RowsCount(); i++)
        {
            for (var j = 0; j < num.ColumnsCount(); j++)
            {
                if(num[i,j] >0)
                    Console.Write(num[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static int [,] Mult3(int [,] num)
    {
        for (var i = 0; i < num.RowsCount(); i++)
        {
            for (var j = 0; j < num.ColumnsCount(); j++)
            {
                num[i, j] *= 3;
            }
        }
        return num;
    }


    static void Main(string[] args)
    {

        Console.Write("Количество строк матрицы :    ");
        var n = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов матрицы : ");
        var m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,m];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Random buf = new Random();
                matrix[i, j] = buf.Next(-30, 31);
            }
        }


        Action<int[,]> w = Show;
        Console.WriteLine("  First task:");
        MethodAct(matrix, w);
        w = ShowPositive;
        Console.WriteLine("  Second task:");
        MethodAct(matrix, w);

        Func<int[,], int[,]> q = Mult3;
        MethodFunc(matrix, q);

        Console.WriteLine("  Final:");
        w = Show;
        MethodAct(matrix, w);
    } 
    
}
