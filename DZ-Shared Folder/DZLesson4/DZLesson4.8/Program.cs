//Составить программу возведения натурального числа в квадрат, учитывая следующую закономерность.

int num = 0;
double z = 0;
Console.Write("Введи число: ");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
	z = Math.Pow(i, 2);
	/*z += 2 * i - 1;*/
	z += 2 * num - 1;
Console.WriteLine(z);
}


Console.Write("n=");
var n = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 1; i <= 2 * n - 1; i += 2)
{
	result += i;
}
Console.WriteLine(result);


/*int number = 4;
int total = 0;

for (int i = 0, j = 1; i < number; i++, j += 2)
	total += j;

Console.WriteLine($"Число {number} в степени 2 = {total}");

Console.ReadKey();*/