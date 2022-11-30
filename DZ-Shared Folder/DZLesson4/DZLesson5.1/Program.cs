// Дана непустая последовательность целых чисел, оканчивающаяся числом 100.
// Определить, есть ли в последовательности число 77? Если имеються несколько таких чисел, то определить порядковый номер первого из них.

Console.Write("Сколько хотите вводить чисел: ");
int count = int .Parse(Console.ReadLine());

int numStart = 0;
int countNum = 0;
int oneNum = 0;

Console.Write("Введите искомое число: ");
int searchOne = int.Parse(Console.ReadLine());

do
{
	int search = int.Parse(Console.ReadLine());

	if (search == searchOne)
	{
		countNum++;
		if (oneNum == 0)
		{
			oneNum = numStart + 1;
		}
	}
	numStart++;
} while (numStart < count);

if (countNum == 0)
{
	Console.WriteLine("Нету чисел 77 в этой последовательности чисел");
}
else
{
		Console.WriteLine($"В последовательности - {countNum} числа 77, число в {oneNum} позиции");
}