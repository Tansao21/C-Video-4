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

//A2 .3.Дано трехзначное число.Найти:
// а) число единиц в нем;
// б) число десятков в нем;
// в) сумму его цифр;
// г) произведение его цифр.
/* Эту задачу очень легко решить в функции Num поменять услови место двух вводить три из менить if*/

//A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.

void Input()
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
	Output(" Ввели не правильно! Введите 2х значное число!");
}