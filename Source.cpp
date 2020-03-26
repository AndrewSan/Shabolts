#include <iostream>
#include <ctime>
using namespace std;

int Search_Binary(int arr[], int left, int right, int key)
{
	int midd = 0;
	while (1)
	{
		midd = (left + right) / 2;
		if (key < arr[midd])       // ���� ������� ������ �������� � ������
			right = midd - 1;      // ������� ������ ������� ������
		else if (key > arr[midd])  // ���� ������� ������ �������� � ������
			left = midd + 1;    // ������� ����� ������� ������
		else                       // ����� (�������� �����)
			return midd;           // ������� ���������� ������ ������
		if (left > right)          // ���� ������� ���������� 
			return -1;
	}
}

int main()
{
	setlocale(LC_ALL, "rus");
	const int SIZE = 100000;
	int mas[SIZE];
	int key = 0;
	int index = 0; // ������ ������ � ������� ���������
	for (int i = 0; i < SIZE; i++) // ��������� � ���������� ������
	{
		mas[i] = i + 1;
	}
	key = 0;
	index = Search_Binary(mas, 0, SIZE, key);
	if (index >= 0)
		cout << "  ��������: " << index << endl << endl;
	else
		cout << "  � ������� ��� ������ �����!" << endl << endl;
	cout << "  ����� ������ �������� - " << clock() << endl;
	return 0;
}