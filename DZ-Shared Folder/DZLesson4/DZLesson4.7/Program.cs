// Даны натуральные числа x и y. Вычислить произведение x * y, используя лишь операцию сложения. Задачу решить двумя способами.


int x;
int y;
int result = 0;
Console.Write("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
y = int.Parse(Console.ReadLine());

for (int i = 0; i < y; i++)
{
	result += x;
}
Console.WriteLine(result);

double resultA = Math.BigMul(x, y);
Console.WriteLine(resultA);