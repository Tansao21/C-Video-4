using System;



/*int count = 3456722;
int num = 0;
int min = 10;
int countnum = 0;

static int Minchislo(int count, int num, int min)
{
	while (count > 0)
	{
		num = count % 10;
		if (num < min)
		{
			min = num;
		}
		count /= 10;
	}
	return min;
}

static int Countchislo (int count, int num, int min, int countnum)
{
	int a = Minchislo(count, num, min);
	while (count > 0)
	{
		num = count % 10;
		if (num == a)
		{
			countnum++;
		}
		count /= 10;
	}
	 return countnum;
}


Console.WriteLine(Minchislo(count, num, min));
Console.WriteLine(Countchislo(count, num, min, countnum));*/



// В некотром году ( назовем его условно первым) на участке в 100 гектаров средняя урожайность ячменя составила 20 центеров с гектара. После этого каждый год площадь участка увеличмвалась на 5%, а средняя урожайность на 2 %. определить:
// а) в каком году урожайность превысит 22 центера с гегтара.
// б) в каком году площадь участка станет больше 120гектаров.
// в) в каком году общий урожай, собранный за все время, начиная с первого года, превысит 800 центеров.


/*double square = 100.0;
double harvestValue = 20.0;
double harvestValueTotal = harvestValue;


int yearHarvestOver22 = 0;
int yearSquareOver120 = 0;
int yearTotalHarvestOver800 = 0;


double harvestOver22Value = 0.0;
double squareOver120Value = 0.0;
double totalHarvestOver800Value = 0.0;

int currentYear = 1;
while (true)
{
	currentYear++;
	square *= 1.05;
	harvestValue *= 1.02;
	harvestValueTotal += harvestValue;

	if (yearHarvestOver22 == 0 && harvestValue > 22.0)
	{
		yearHarvestOver22 = currentYear;
		harvestOver22Value = harvestValue;
	}

	if (yearSquareOver120 == 0 && square > 120.0)
	{
		yearSquareOver120 = currentYear;
		squareOver120Value = square;
	}

	if (yearTotalHarvestOver800 == 0 && harvestValueTotal > 800.0)
	{
		yearTotalHarvestOver800 = currentYear;
		totalHarvestOver800Value = harvestValueTotal;
	}

	if (yearHarvestOver22 > 0 && yearSquareOver120 > 0 && yearTotalHarvestOver800 > 0)
	{
		Console.WriteLine($"Урожайность превысит 22 центнера с гектара в {yearHarvestOver22} году: {Math.Round(harvestOver22Value, 2)}.");
		Console.WriteLine($"Площадь участка станет больше 120 гектаров в {yearSquareOver120} году: {Math.Round(squareOver120Value, 2)}.");
		Console.WriteLine($"Общий урожай, собранный за все время, начиная с первого года, превысит 800 центнеров в {yearTotalHarvestOver800} году: {Math.Round(totalHarvestOver800Value, 2)}.");
		break;
	}
}*/



/*double N6area = 100;
double N6product = 20;
double N6sum = 2000;
static double All(double N6area, double N6product, double N6sum)
{
for (int a = 2; a <= 8; a++)
{
	N6area = 1.05;
	N6product = 1.02;
	if (a <= 6) N6sum += (N6area * N6product);
	Console.Write($"\nНа {a} год площадь засева {N6area:f2} га");
	if (a <= 7) Console.Write($", урожайность {N6product:f2} ц/га");
}
	return N6sum;
}



Console.WriteLine($"\nСуммарный урожай за первых 6 лет {N6sum:f2} ц", All(N6area, N6product, N6sum));
Console.ReadKey();
Console.Clear();*/



/*int n;
 int N()
{
	Console.Write("n=");
	n = int.Parse(Console.ReadLine());
	return n;
}
Console.WriteLine(N());*/


// напечатать мин число >200 кратное 17 

/*int a;
int b;
int A()
{
	Console.WriteLine($"Введите минимальное число от 200, которое кратно 17");
	int a = int.Parse(Console.ReadLine());
	return a;
}
int C = A();

static int B(int C)
{
bool c = true;
	while (C < 200)
	{
		Console.WriteLine($"Введите минимальное число ОТ 200, кратное 17");
		C = int.Parse(Console.ReadLine());
	}
	while (c)
	{

		int b = C/ 17;
		if (b == 12)
		{
			Console.WriteLine($" Минимальное число от 200 кратное 17 = {C} ");
			c = false;
		}
		else
		{
		Console.WriteLine($"Это число не кратно 17, попробуйте снвоа");
		C = int.Parse(Console.ReadLine());
		}

	}
	return C;
}
Console.WriteLine(B(C));*/