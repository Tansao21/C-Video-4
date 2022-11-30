// Дано натуральное число. Верно ли, что сумма его цифр больше 10?

int num;
int i = 0;
int sum = 0;
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
int count = num % 10;


do
{
	sum = sum + count;
	num= num / 10;
	i++;
} while (i < num);

	if (sum >= 10)
	{
		Console.WriteLine("Сумма  цифр больше 10 или равна 10");
	}
	else
	{
		Console.WriteLine("Сумма  цифр НЕ больше 10");
	}

