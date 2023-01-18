//A2 .1.Дано двузначное число.Найти:
// а) число десятков в нем;
// б) число единиц в нем;
// в) сумму его цифр;
// г) произведение его цифр.

int num;
bool a = true;
/* void Input()
{
		Console.WriteLine("Введите двухзначное число: ");
		num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 100 && num > 10)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 99 && num >= 10)
		{

			int desatki = num / 10;
			int edinic = num % 10;
			int sumEgoCifor = num % 10 + num / 10;
			int proizvedenie = (num % 10) * (num / 10);

			Console.WriteLine($"Число десяток в нем =  {desatki}");
			Console.WriteLine($"Число единиц в нем = {edinic}");
			Console.WriteLine($"Сумма его цифр = {sumEgoCifor}");
			Console.WriteLine($"Произведение его цифр = {proizvedenie}");

			//A2 .2.Дано двузначное число.Получить число, образованное при перестановке цифр заданного числа.
			Console.WriteLine();

			int numOne = edinic;
			int numTwo = desatki;
			Console.WriteLine($"{numOne}{numTwo}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output (string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
	Num(num);
	a = false;
	} while (a);
}
catch 
{
	Output(" Ввели не правильно! Введите 2х значное число!");
}*/

/*//A2 .3.Дано трехзначное число.Найти:
// а) число единиц в нем;
// б) число десятков в нем;
// в) сумму его цифр;
// г) произведение его цифр.
*//* Эту задачу очень легко решить в функции Num поменять услови место двух вводить три из менить if*/

//A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.

/*void Input()
{
	Console.WriteLine("Введите трехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{
			int sotni = num/ 100;
			int desatki = (num / 10)% 10;
			int edinic = num % 10;
			

			Console.WriteLine($"Число десяток в нем =  {sotni}");
			Console.WriteLine($"Число десяток в нем =  {desatki}");
			Console.WriteLine($"Число единиц в нем = {edinic}");

			Console.WriteLine();

			int numOne = edinic;
			int numTwo = desatki;
			int numThree = sotni;
			Console.WriteLine($"{numOne}{numTwo}{numThree}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		a = false;
	} while (a);
}
catch
{
	Output(" Ввели не правильно! Введите 3х значное число!");
}*/


//A2.5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.

/*void Input()
{
	Console.WriteLine("Введите трехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{
			int sotni = num/ 100;
			int desatki = num % 100;
		
			

			Console.WriteLine($"Число соток в нем =  {sotni}");
			Console.WriteLine($"Число десяток в нем =  {desatki}");
		

			Console.WriteLine();

			int numOne = desatki;
			int numTwo = sotni;
			Console.WriteLine($"{numOne}{numTwo}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		a = false;
	} while (a);
}
catch
{
	Output(" Ввели не правильно! Введите 3х значное число!");
}*/


//A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.

/* void Input()
{
	Console.WriteLine("Введите трехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{
			int sotni = num / 100;
			int desatki = (num % 100);



			Console.WriteLine($"Число сотки в нем =  {sotni}");
			Console.WriteLine($"Число десяток в нем =  {desatki}");


			Console.WriteLine();

			int numOne = desatki;
			int numTwo = sotni;
			Console.WriteLine($"{numOne}{numTwo}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		
	} while (!a);
}
catch
{
	Output(" Ввели не правильно! Введите 3х значное число!");
}*/

//A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.

/*void Input()
{
		Console.WriteLine("Введите трехзначное число: ");
		num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{

			int sotca = num / 100;
			int decatka = num % 100 / 10;
			int edinica = num % 10;


			Console.WriteLine($"Число сотки в нем =  {sotca}");
			Console.WriteLine($"Число десятки в нем = {decatka}");
			Console.WriteLine($"Число единицы в нем = {edinica}");


			Console.WriteLine();

			int numOne = sotca;
			int numTwo = decatka;
			int numThee = edinica;
			Console.WriteLine($"{numTwo}{numOne}- {numThee}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output (string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
	Num(num);
	a = false;
	} while (a);
}
catch 
{
	Output(" Ввели не правильно! Введите 3х значное число!");
}*/


//A2 .8.Дано трехзначное число.Найти число, полученное при перестановке второй и третьей цифр заданного числа.

/*void Input()
{
	Console.WriteLine("Введите трехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{

			int sotca = num / 100;
			int decatka = num % 100 / 10;
			int edinica = num % 10;


			Console.WriteLine($"Число сотки в нем =  {sotca}");
			Console.WriteLine($"Число десятки в нем = {decatka}");
			Console.WriteLine($"Число единицы в нем = {edinica}");


			Console.WriteLine();

			int numOne = sotca;
			int numTwo = decatka;
			int numThee = edinica;
			Console.WriteLine($"{numOne}-{numThee}{numTwo} ");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		a = false;
	} while (a);
}
catch
{
	Output(" Ввели не правильно! Введите 3х значное число!");
}*/

//A2.9. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.

/*void Input()
{
	Console.WriteLine("Введите трехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 1000 && num > 100)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 999 && num >= 100)
		{

			int sotca = num / 100;
			int decatka = num % 100 / 10;
			int edinica = num % 10;


			Console.WriteLine($"Число сотки в нем =  {sotca}");
			Console.WriteLine($"Число десятки в нем = {decatka}");
			Console.WriteLine($"Число единицы в нем = {edinica}");


			Console.WriteLine();

			int numOne = sotca;
			int numTwo = decatka;
			int numThee = edinica;
			Console.WriteLine($"{numOne}-{numTwo}-{numThee}");
			Console.WriteLine($"-------------");

			Console.WriteLine($"{numOne}{numTwo}{numThee}");
			Console.WriteLine($"{numTwo}{numOne}{numThee}");
			Console.WriteLine($"{numThee}{numTwo}{numOne}");
			Console.WriteLine($"{numThee}{numOne}{numTwo}");
			Console.WriteLine($"{numOne}{numThee}{numTwo}");
			Console.WriteLine($"{numTwo}{numThee}{numOne}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		Input();
	} while (!a);

}
catch
{
	Output(" Ввели не правильно! Введите 3х значное число!");
	Input();
}*/


//A2.10. Дано четырехзначное число. Найти:

/*void Input()
{
	Console.WriteLine("Введите четырехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

// а) сумму его цифр;
static int Sum(int tisacha, int sotca, int decatka, int edinica)
{
	int sum = tisacha + sotca + decatka + edinica;
	return sum;
}
// б) произведение его цифр.
static int Mul (int tisacha, int sotca, int decatka, int edinica)
{
	int mul = tisacha * sotca * decatka * edinica;
	return mul;
}
static int Num(int num)
{
	if (num < 10000 && num > 1000)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 9999 && num >= 1000)
		{
			int tisacha = num / 1000;
			int sotca = num / 100 % 10;
			int decatka = num % 100 / 10;
			int edinica = num % 10;

			Console.WriteLine($"Число тысяча в нем =  {tisacha}");
			Console.WriteLine($"Число сотки в нем =  {sotca}");
			Console.WriteLine($"Число десятки в нем = {decatka}");
			Console.WriteLine($"Число единицы в нем = {edinica}");

			Console.WriteLine("--------------");

			Console.WriteLine(Sum(tisacha, sotca, decatka, edinica));

			Console.WriteLine("--------------");

			Console.WriteLine(Mul(tisacha, sotca, decatka, edinica));

		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
	} while (!a);

}
catch
{
	Output(" Ввели не правильно! Введите 4х значное число!");
	Input();
}
*/


//A2.11. Дано четырехзначное число. Найти:

// Последнюю задачу решить двумя способами:
// 1) с выделением отдельных цифр заданного числа;
// 2) без выделения отдельных цифр заданного числа.

/*void Input()
{
	Console.WriteLine("Введите четырехзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 10000 && num > 1000)
	{
		Console.WriteLine("Ввели верно");
		if (num <= 9999 && num >= 1000)
		{
			int tisacha = num / 1000;
			int sotca = num / 100 % 10;
			int decatka = num % 100 / 10;
			int edinica = num % 10;

			Console.WriteLine($"Число тысяча в нем =  {tisacha}");
			Console.WriteLine($"Число сотки в нем =  {sotca}");
			Console.WriteLine($"Число десятки в нем = {decatka}");
			Console.WriteLine($"Число единицы в нем = {edinica}");

			Console.WriteLine("--------------");
// а) число, полученное при прочтении его цифр справа налево;
			Console.WriteLine($" число, полученное при прочтении его цифр справа налево: {edinica}{decatka}{sotca}{tisacha}");

			Console.WriteLine("--------------");
// б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
			Console.WriteLine($" число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа: {sotca}{tisacha}{edinica}{decatka}");

			Console.WriteLine("--------------");
// в) число, образуемое при перестановке второй и третьей цифр заданного числа. Например, из числа 5084 получить 5804;
			Console.WriteLine($"число, образуемое при перестановке второй и третьей цифр заданного числа: {tisacha}{decatka}{sotca}{edinica}");

			Console.WriteLine("--------------");
// г) число, образуемое при перестановке двух первых и двух последних цифр заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
			Console.WriteLine($"число, образуемое при перестановке двух первых и двух последних цифр заданного числа: {decatka}{edinica}{tisacha}{sotca}");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
	} while (!a);

}
catch
{
	Output(" Ввели не правильно! Введите 4х значное число!");
	Input();
}*/


//A2 .12.Дано натуральное число n (n > 9). Найти:
// а) число единиц в нем;
// б) число десятков в нем.

/*void Input()
{
	Console.WriteLine("Введите  двухзначное число: ");
	num = int.Parse(Console.ReadLine());
}

static int Num(int num)
{
	if (num < 100 && num > 10)
	{
		Console.WriteLine("Ввели верно");
		if (num < 99 && num > 10)
		{

			int desatki = num / 10;
			int edinic = num % 10;


			Console.WriteLine($"Число десяток в нем =  {desatki}");
			Console.WriteLine($"Число единиц в нем = {edinic}");

			Console.WriteLine();

			int numOne = edinic;
			int numTwo = desatki;
			Console.WriteLine($"единиц = {numOne}; десятки = {numTwo}.");
		}

	}
	else if (num > 100 || num < 10)
	{
		Console.WriteLine("Неверное число");
	}
	return num;
}

void Output(string msg)
{
	Console.WriteLine(msg);
}

try
{
	Input();
	do
	{
		Num(num);
		a = false;
	} while (a);
}
catch
{
	Output(" Ввели не правильно! Введите 2х значное число!");
}*/

// A2 .13.Дано натуральное число n (n > 99). Найти:
// а) число десятков в нем;
// б) число сотен в нем.
// A2.14. Дано натуральное число n (n > 999). Найти:
// а) число сотен в нем;
// б) число тысяч в нем. Делаеться по аналогии как и выше задача.Изменение if))))