//Составить программу возведения натурального числа в квадрат, учитывая следующую закономерность.

int num = 0;
double z = 0;
Console.Write("Введи число: ");
num = int.Parse(Console.ReadLine());

for (int i = 1; i < num; i++)
{
	z = Math.Pow(i, 2);
	/*z += 2 * i - 1;*/
	z += 2 * num - 1;
}
Console.WriteLine(z);



