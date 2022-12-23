// 1) дан массив, там точно есть одинаковые элементы вывести индексы пар одинаковых элементов например ввод: 4 5 6 7 4 5 8 вывод: 0 - 4, 1 - 5

/*
int[] mas = new int[10];
int num;

Console.WriteLine("Input num: ");
num = int.Parse(Console.ReadLine());



for (int i = 0;i < mas.Length; i++)
{
	Console.Write("Input massiv: ");
	mas[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < mas.Length - 1; i++)
{
int temp = mas[i];
	for (int j = i + 1; j < mas.Length; j++)
	{
		if (mas[j] == temp)
		{
			Console.Write($"Index {j} in num {temp}");
		}
	}
}
*/


int[] mas = new int[] { 4, 5, 6, 7, 4, 5, 8 };

for (int i = 0; i < mas.Length - 1; i++)
{
	int origin = mas[i];
	int indexOrigin = i;
	for (int j = i + 1; j < mas.Length; j++)
	{
		if (mas[j] == origin)
		{
			Console.WriteLine($"val = {origin} index1 = {indexOrigin} index2 = {j}");
		}
	}
}

// 2)совместить с удалением - удалить все одинаковые числа в массиве - делать до тех пор пока одинкаовых чисел не останется, все будут уникальные ввод: 4 5 6 7 4 5 8 вывод: 4 5 6 7 8 




//1)сделать сравнение 2х длинных чисел выдать 1 если 1 >  выдать - 1 если 1 <  выдать 0 если 1 == 2