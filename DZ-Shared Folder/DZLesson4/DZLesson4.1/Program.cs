// Найти сумму 2^2+2^3+....+2^10.Операцию в возведение в степень не использовать.

int numberTwo = 2;
int iter = 1;
int count = 10;
int sum = 0;

while (iter < count)
{
	numberTwo += numberTwo;
	iter++;
	sum = numberTwo;

}
	Console.WriteLine($"summa {sum}");
