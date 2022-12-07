// Среднее арифметическое всех целых чисел от  а до b.


/*int numA = 0;
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
Console.WriteLine(a);*/


int numA, numB, sum = 0,  number;
double sredAr;
Console.Write("Введите число numA : ");
numA = int.Parse(Console.ReadLine());
Console.Write("Введите число numB : ");
numB = int.Parse(Console.ReadLine());

number = numB - numA + 1;

for (int i =numA; i <= numB; i++)
{
	sum += numA;
}
sredAr = sum / (double)number;
Console.WriteLine(sredAr);