// Определить: Являеться ли заданное число спепенью 3.

int number;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());
for (int i = 3; i < number; i++)
{
	i *= 3;
	if (i == number)
	{
		Console.WriteLine("Число являеться степенью три!");
	}
	else
	{
		Console.WriteLine("Число не являеться степенью три!");
	}
}