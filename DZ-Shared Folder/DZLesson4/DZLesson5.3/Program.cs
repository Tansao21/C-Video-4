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

	if (sum > 10)
	{
		Console.WriteLine("Сумма  цифр больше 10");
	}
	else
	{
		Console.WriteLine("Сумма  цифр НЕ больше 10");
	}

/*	int n, s = 0;
	Console.Write("Введите натуральное число: ");
	n = Convert.ToInt32(Console.ReadLine());
	while (n != 0)
	{
		s = s + n % 10;
		n = n / 10;
	}
	if (s > 10)
		Console.WriteLine("Сумма  цифр больше 10");
	else
		Console.WriteLine("Сумма  цифр НЕ больше 10");
	Console.ReadKey();*/
