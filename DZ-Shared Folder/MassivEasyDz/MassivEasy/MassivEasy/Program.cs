// Дан массив. Все его элементы.

/*int[] mas = new int[10];*/

// а) увеличить все его элименты в два раза

/*for (int i = 0; i < mas.Length; i++)
{
	Console.Write("Введите массив: ");
	mas[i] = Convert.ToInt32(Console.ReadLine());
	mas[i] *= 2;
}

for (int i = 0; i < mas.Length; i++) Console.WriteLine(mas[i]);*/


// б) уменьшить на число А 

/*int numA;

Console.Write("Введите число А: ");
numA = int.Parse(Console.ReadLine());

for (int i = 0; i < mas.Length; i++)
{
	Console.Write("Введите массив: ");
	mas[i] = Convert.ToInt32(Console.ReadLine());
	mas[i] -= numA;
}

for (int i = 0; i < mas.Length; i++) Console.WriteLine(mas[i]);*/


// в) разделить на первый элемент

/*int masA;
int masB = 0;
for (int i = 0; i < mas.Length; i++)
{
	Console.Write("Введите массив: ");
	mas[i] = Convert.ToInt32(Console.ReadLine());
	masA =  mas[0];
	masB = mas[i] / masA;
}

for (int i = 0; i < mas.Length; i++) Console.WriteLine(masB); */



// В массиве хранятся сведенья о количестве осадков, выпавших за каждый день июня. Определить общее количество осадков, выпавших за каждую декаду этого месяца.


/*int[] precipitationArr = new int[30];
int dek = 0, i;


for ( i = 0; i < precipitationArr.Length; i++)
{
	Console.Write("Введите количество осадков: ");
	precipitationArr[i] = Convert.ToInt32(Console.ReadLine());
}

for ( i = 0; i < 10; i++)
{
	dek += precipitationArr[i];
}
Console.WriteLine("За первую декаду выпало " + dek + "осадков.");

dek = 0;	
for ( i = 10; i < 20; i++)
{
	dek+= precipitationArr[i];
}
Console.WriteLine("За вторую декаду выпало " + dek + "осадков.");

dek = 0;
for (i = 20; i < 30; i++)
{
	dek += precipitationArr[i];
}
Console.WriteLine("За третью декаду выпало " + dek + "осадков.");*/


// В массиве храниться информация о численности книг в каждом из 35 разделов библиотеки. Выяснить , верно ли, что общее число книг в библиотеке есть шестизначное число.

/*int[] masBook = new int[35];
int sum = 0;

for (int i = 0; i < masBook.Length; i++)
{
	Console.Write("Введите количество книг: ");
	masBook[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < masBook.Length; i++)
{
	sum += masBook[i];
}

	if (sum > 99999 && sum < 1000000)
	{
		Console.Write("Верно!");
	}
	else
	{
		Console.Write("Не верно!");
	}*/


// Дан массив вещественных чисел.


// а) Из всех положительных элементов вычесть элемент с номером к1, из остальных - элемент с номером к2.

/*int [] mas = { -12,13,14,-15,23,43,-45,65}; 
int k1 = 6; int k2 = 7;

for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] > 0)
	{
		mas[i] -= k1;
	}
	else
	{
		mas[i] -= k2;
	}
}
for (int i = 0; i < mas.Length; i++) Console.WriteLine(mas[i]);*/


// б) Все элементы с нечетными номерами увеличить на 1, с четными - уменьшить на 1.

/*int[] mas = { 12, 13, 14, 15, 23, 43, 45, 65 };

for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] % 2 == 0)
	{
		mas[i] -= 1;
	}
	else
	{
		mas[i] += 1;
	}
}
for (int i = 0; i < mas.Length; i++) Console.WriteLine(mas[i]);*/

// Дан массив.Найти:

// а) Сумму элементов массива, значение которых не превышает 20.

/*int[] mas = { 2,3,4,5,6,7,8,9,11,12,13};
int sum = 0;
int numA = 11;*/

/*for (int i = 0; i < mas.Length; i++)
{
	sum += mas[i];
	if (sum < 20)
	{
		Console.WriteLine(sum);
	}
}*/

// б) сумма элементов массива, больших числа а.

/*for (int i = 0; i < mas.Length; i++)
{
	sum += mas[i];
	if (sum > numA)
	{
		Console.WriteLine(sum);
	}
}*/


// Известен рост 30 учеников школы. Сколько из них имеет рост больше 170? Можно ли сформировать баскедбольную команду ( в команде должно быть не менее пяти человек ростом больше 170см)?

int[] studets = new int[6];
int pipol = 5;
int height = 170;
int count = 0;

for (int i = 0;i < studets.Length; i++)
{
	Console.Write("Введите рост учеников: ");
	studets[i] = Convert.ToInt32(Console.ReadLine());


	if (height < studets[i])
	{
		count ++;
		Console.WriteLine(count);

	}
}
	if (pipol == count)
	{
		Console.WriteLine("Команду можно собрать!");
	}
	else
	{
		Console.WriteLine("Команду не собрать!");
	}