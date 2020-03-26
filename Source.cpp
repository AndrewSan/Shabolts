#include <iostream>
#include <ctime>
using namespace std;

int Search_Binary(int arr[], int left, int right, int key)
{
	int midd = 0;
	while (1)
	{
		midd = (left + right) / 2;
		if (key < arr[midd])       // если искомое меньше значени€ в €чейке
			right = midd - 1;      // смещаем правую границу поиска
		else if (key > arr[midd])  // если искомое больше значени€ в €чейке
			left = midd + 1;    // смещаем левую границу поиска
		else                       // иначе (значени€ равны)
			return midd;           // функци€ возвращает индекс €чейки
		if (left > right)          // если границы сомкнулись 
			return -1;
	}
}

int main()
{
	setlocale(LC_ALL, "rus");
	const int SIZE = 100000;
	int mas[SIZE];
	int key = 0;
	int index = 0; // индекс €чейки с искомым значением
	for (int i = 0; i < SIZE; i++) // заполн€ем и показываем массив
	{
		mas[i] = i + 1;
	}
	key = 0;
	index = Search_Binary(mas, 0, SIZE, key);
	if (index >= 0)
		cout << "  »ндексом: " << index << endl << endl;
	else
		cout << "  ¬ массиве нет такого числа!" << endl << endl;
	cout << "  ¬рем€ роботы програмы - " << clock() << endl;
	return 0;
}