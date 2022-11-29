// Вычеслить сумму 1 + 1/2 + 1/3 +....+ 1/n.
int num;
float number = 1;
Console.Write("Введите число num: ");
num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
	number += number /  i;

}
	Console.WriteLine(number);

    