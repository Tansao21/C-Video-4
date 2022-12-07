// Вычеслить сумму 1 + 1/2 + 1/3 +....+ 1/n.
double num;
double number = 1;
double sum = 0;
Console.Write("Введите число num: ");
num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
	/*number += number / i;*/
	/*number = number + 1 / i;*/
	sum += number / i;
}
Console.WriteLine(number);

/*double n1 = 1, n2, sum = 0;
Console.Write("Введите число n: ");
n2 = int.Parse(Console.ReadLine());

while (n1 <= n2)
{
	sum += 1.0 / n1;
	n1++;
}
Console.WriteLine(sum);*/
