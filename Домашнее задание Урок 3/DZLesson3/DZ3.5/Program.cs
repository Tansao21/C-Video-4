// Найти
// а) Сумму всех целых чисел от 100 до 500;

/*int i = 100;
int num = 500;
int sum = 0;
while (i <= num)
{
	 sum += i;
	i++;
}
	Console.WriteLine(sum);*/

//б) Сумма всех целых чисел от а до 500 (значение а вводиться с клавиатуры а<=500);

/*int iter;
int numB = 500;
int sumOne = 0;
Console.Write("Введите число: ");
iter = int.Parse(Console.ReadLine());

while (iter <= numB)
{
	sumOne += iter;
	iter++;
}
Console.WriteLine(sumOne);*/


//в) Сумма всех целых чисел от -10 до b (значение b вводиться с клавиатуры b>=-10);

/*int iter = -10;
int numB;
int sumOne = 0;
Console.Write("Введите число: ");
numB = int.Parse(Console.ReadLine());

while (iter <= numB)
{
	sumOne += iter;
	iter++;
}
Console.WriteLine(sumOne);*/

//г) Сумма всех целых чисел от a до b (значение b вводиться с клавиатуры b>=a);

int iter;
int numB;
int sumOne = 0;
Console.Write("Введите число: ");
iter = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
numB = int.Parse(Console.ReadLine());

while (iter <= numB)
{
	sumOne += iter;
	iter++;
}
Console.WriteLine(sumOne);
