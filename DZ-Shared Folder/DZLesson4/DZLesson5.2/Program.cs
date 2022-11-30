// Дано натуральное число.Определить: сколько раз в нем встречаеться цифра а?

int numNatur;
int numSearch;
int count = 0;

		Console.Write("Введите натуральное число: ");
		numNatur = int.Parse(Console.ReadLine());
		
		Console.Write("Введите искомое число: ");
		numSearch = int.Parse(Console.ReadLine());
do
{

	try
	{
		if (numNatur % 10 == numSearch)
		
			count++;
			numNatur /= 10;
		
		
		if (numNatur < 0 && numSearch < 0)
		{
			Console.WriteLine("Ошибка должно быть число больше 0 и положительное!");
		}

	}
	catch (Exception exeption)
	{
		Console.WriteLine(exeption.Message);
		Console.WriteLine("Ошибка!!!!");
		numNatur = 0;
	}

} while (numNatur != 0);

	Console.Write($"Количество цифр в числе - {count}");





/*do
{
	if (numNatur % 10 == numSearch)
		count++;
	numNatur /= 10;
} while (numNatur != 0);

Console.Write($"Количество цифр в числе - {count}");*/


