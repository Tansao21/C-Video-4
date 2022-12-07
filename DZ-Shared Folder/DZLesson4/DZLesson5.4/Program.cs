// Дано натуральное число.Определить: есть ли в нем цифра 3.

int count = 0;
int num;
Console.Write(" Введите натуральное число: ");
int numOne = int.Parse(Console.ReadLine());

for (int i = 0; i < numOne; i++)
{
	num = numOne % 10;
	if (num == 3)
	{
		count++;
	}
	numOne = numOne / 10;
}
if (count > 0)
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("No");
}


/*int count = 0; // это счетчик
int num3 = 0; // поиск числа 3
Console.WriteLine("Ведите число");
int num = int.Parse(Console.ReadLine());
for (int i = 0; num > 0; i++)
{
	num3 = num % 10;
	if (num3 == 3)
	{
		count++;

	}
	num = num / 10;
}
if (count > 0)
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("No");
}*/

/*int count = 0; // это счетчик
int num3 = 0; // поиск числа 3
Console.WriteLine("Ведите число");
int num = int.Parse(Console.ReadLine());
while (num > 0)
{
	num3 = num % 10;
	Console.WriteLine(num3);
	if (num3 == 3)
	{
		count++;

	}
	num = num / 10;
}
Console.WriteLine($"число 3 встречаеться {count} раз");
*/