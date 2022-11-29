//Произведение всех целых чисел от a до b.( значени вводится с клавиатуры)

int numA = 0;
int numB = 0;
int a = 1;

Console.Write("Введите число numA : ");
numA = int.Parse(Console.ReadLine());
Console.Write("Введите число numB : ");
numB = int.Parse(Console.ReadLine());

for (int i = numA; i <= numB; i++)
{
	a *= i;
}
Console.WriteLine(a);
