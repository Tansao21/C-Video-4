// Среднее арифметическое всех целых чисел от  а до b.


int numA = 0;
int numB = 0;
int a = 1;

Console.Write("Введите число numA : ");
numA = int.Parse(Console.ReadLine());
Console.Write("Введите число numB : ");
numB = int.Parse(Console.ReadLine());

for (int i = numA; i <= numB; i++)
{
	a += i / 2;
}
Console.WriteLine(a);