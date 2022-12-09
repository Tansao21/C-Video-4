// Заполнит массив от 1,2,3...12.
/*int[] mas = new int [12];

for (int i = 0; i < 12; i++)
{
	mas[i] = i;
}

for (int i = 0; i < 12; i++)
{
	Console.WriteLine(mas[i]);
}*/




// Заполнит массивиз 20 элементов 20,19,18,...1.

/*int[] massiv= new int[20];

for (int i = 0; i < 20; i++) massiv[i] = 19 + 1 - i;
for (int i = 0; i < 20; i++) Console.WriteLine(massiv[i]);*/




//Составить программу вывода на экран любого элемента массива по индексу. С этим заданием не уверен что праильно понял как решать!!!!!!!

int[] massis = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine(massis[8]);




// Вывести элементы мвссива в обратном порядке.

/*int[] massis = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < massis.Length; i++) Console.WriteLine(massis[i] = massis.Length - i );*/




// Дан массив. Напечтатьть: а) все неотрицательные элементы.

/*int[] massis = { -1, 2, 3, -4, 5, 6, 7, -8, -9 };
for (int i = 0; i < massis.Length; i++)
{
	if (massis[i] > 0)
	{
		Console.WriteLine(massis[i]);
	}
}*/