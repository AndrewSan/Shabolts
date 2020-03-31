using System;

namespace Buferok_2._0
{
    class BooksInTheLibrary
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public int Code { get; set; }

        public BooksInTheLibrary() { }
        public BooksInTheLibrary(string author, string title, string genre, int code, int year, int pages)
        {
            Author = author;
            Title = title;
            Genre = genre;
            Code = code;
            Year = year;
            Pages = pages;
        }
        public void toString()
        {
            Console.WriteLine($"ФИО автора - {Author}");
            Console.WriteLine($"Название книги - {Title}");
            Console.WriteLine($"Жанр - {Genre}");
            Console.WriteLine($"Код в библиотеке - {Code}");
            Console.WriteLine($"Год издания - {Year}");
            Console.WriteLine($"Количество страниц - {Pages}");
        }

        public void Input()
        {
            Console.WriteLine($"ФИО автора - {Author}");
            Author = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Название книги - {Title}");
            Title = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Жанр - {Genre}");
            Genre = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Код в библиотеке - {Code}");
            Code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Год издания - {Year}");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество страниц - {Pages}");
            Pages = Convert.ToInt32(Console.ReadLine());
        }
        public static bool Comparison(BooksInTheLibrary obj_1, BooksInTheLibrary obj_2, int parametr)
        {
            if (parametr == 1)
                if (obj_1.Author == obj_2.Author)
                    return true;
                else if (parametr == 2)
                    if (obj_1.Title == obj_2.Title)
                        return true;
                    else if (parametr == 3)
                        if (obj_1.Genre == obj_2.Genre)
                            return true;
                        else if (parametr == 4)
                            if (obj_1.Code == obj_2.Code)
                                return true;
                            else if (parametr == 5)
                                if (obj_1.Year == obj_2.Year)
                                    return true;
                                else if (parametr == 6)
                                    if (obj_1.Pages == obj_2.Pages)
                                        return true;
            return false;
        }
        public static bool Find(int code, BooksInTheLibrary[] obj, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (obj[i].Code == code)
                {

                    obj[i].toString();
                    return true;
                }
            }
            return false;
        }
    }
}

