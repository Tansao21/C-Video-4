// Напичатать в столбик:
// а) все целые числа от 20 до 35;

/*int i = 20;
int number = 35;
while (i <= number)
{
	Console.WriteLine($"{i}");
	i++;
}*/

// б) Квадраты всех чисел от 10 до b (значение b вводиться с клавиатуры; b >= 10);

/*int iter = 10;
int num;
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine());
while (iter <= num)
{
	if (num >= 10)
	{
		int square = (int)Math.Pow(iter, 2);
		Console.WriteLine($" индекс {iter} {square}");
	}
	iter++;
}*/


// в) Третьи степени всех целых чисел от a до 50 ( значение а вводиться с клавиатуры; a <= 50);


/*int iterNumA;
Console.Write("Введите число: ");
iterNumA = int.Parse(Console.ReadLine());
while (iterNumA <= 50)
{
	if (iterNumA <= 50)
	{
		int tree = (int)Math.Pow(iterNumA, 3);
		Console.WriteLine($" индекс {iterNumA} {tree}");
	}
	iterNumA++;
}*/


// г) Все целые числа от a до b ( значение а и b вводиться с клавиатуры; b >= a).

int iterNumA;
int numB;
Console.Write("Введите число A: ");
iterNumA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
numB = int.Parse(Console.ReadLine());

while (iterNumA <= numB)
{
	if (numB >= iterNumA)
	{
		Console.WriteLine($" {iterNumA}");
	}
	iterNumA++;
}