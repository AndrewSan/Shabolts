using System;

namespace Buferok_2._0
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Введите количество книг - ");
                int size = Convert.ToInt32(Console.ReadLine());
                while (size < 5)
                {
                    Console.WriteLine("Не мньше 5. Попробуйте еще раз");
                    size = Convert.ToInt32(Console.ReadLine());
                }
                BooksInTheLibrary[] objectsArray = new BooksInTheLibrary[size];
                Console.WriteLine("Введите параметры книг");
                for (int i = 0; i < size; i++)
                {
                    objectsArray[i] = new BooksInTheLibrary();
                    objectsArray[i].Input();
                    Console.WriteLine("");
                }
                Console.WriteLine("Введите код для поиска книги");
                int find_code = Convert.ToInt32(Console.ReadLine());
                if (!BooksInTheLibrary.Find(find_code, objectsArray, size))
                {
                    Console.WriteLine("Книги с таким кодом не найдено");
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка");
            }
        }
    }
}


