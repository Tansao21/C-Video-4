﻿//сделать сравнение 2х длинных чисел
//выдать 1 если 1 > 2
//выдать - 1 если 1 < 2
//выдать 0 если 1 == 2

/*int numOne, numTwo;
int[] masOne, masTwo;
int result;

Console.Write("Input numOne: ");
numOne = int.Parse(Console.ReadLine());

masOne= new int[numOne];
for (int i = 0; i < numOne; i++)
{
masOne[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

Console.Write("Input numTwo: ");
numTwo = int.Parse(Console.ReadLine());

masTwo = new int[numTwo];
for (int i = 0; i < numTwo; i++)
{
	masTwo[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

if (numOne > numTwo)
{
	result = 1;
}
else if (numOne < numTwo)
{
	result = -1;
}
else
{
  result = 0;

for (int i = 0; i < numOne; i++)
{
	if (masOne[i] > masTwo[i])
	{
		result = 1;
		break;
	}
	else if (masOne[i] < masTwo[i])
	{
		result = -1;
		break;
	}
}
}
	Console.WriteLine(result);*/



//сделать реверс всех столбцов массива .


/*int n = 5;

int[,] mas = new int[n,n];

Random rnd = new Random();

for (int i = 0; i < n; i++)
{
	Console.WriteLine();
	for (int j = 0; j < n; j++)
	{
	mas[i, j] = rnd.Next(0, 9);
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write("{0}", mas[i, j]);
	}
	Console.WriteLine();
}


int rever;

for (int j = 0; j < n; j++)
{
	for (int i = 0; i < n; i++)
	{
		rever = mas[i,n-j-1];
		mas[i, n - j - 1] = mas[i,j];
		mas[i,j] = rever;
	}
}

for (int j = 0; j < n; j++)
{
	Console.WriteLine();
	for (int i = 0; i < n; i++)
	{
		Console.Write("{0}", mas[i, j]);
	}
}*/


// сделать реверс всех строк

/*int bufer;
int n = 5, m = 5;
int[,] mas = new int[n, m];

Random rnd = new Random();

for (int i = 0; i < n; i++)
{
	Console.WriteLine();
	for (int j = 0; j < n; j++)
	{
		mas[i, j] = rnd.Next(0, 9);
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		Console.Write("{0}", mas[i,j]);
	}
	Console.WriteLine();
}

for (int j = 0; j < m; j++)
{
	for (int i = 0; i < (n / 2); i++)
	{
		bufer = mas[i, j];
		mas[i, j] = mas[n - 1 - i, j];
		mas[n - 1 - i, j] = bufer;
	}
}

for (int i = 0; i < n; i++)
{
	Console.WriteLine();
	for (int j = 0; j < m; j++)
	{
		Console.Write("{0}", mas[i, j]);
	}
}*/

// Задача про вагоны

/*int n = 18, m = 36, position , numberWagon;
bool proverChisel;
Random rnd = new Random();

int[,] mas = new int[n, m];
int[] nas = new int[n];

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		mas[i, j] = rnd.Next(0, 2);
	}
}
for (int i = 0;i < n; i++)
{
	position = 0;
	for (int j = 0; j < m; j++)
	{
		if (mas[i,j] == 0)
		{
			position++;
		}
	}
	nas[i] = position;
}
while (true)
{
do
{
	Console.Write("Введите номер вагона N от 1 до 18: ");
	proverChisel = int.TryParse(Console.ReadLine(), out numberWagon);

} while (proverChisel == false || numberWagon < 1 || numberWagon > 18);

	Console.WriteLine("\n Количество свободных мест в вагоне N" + numberWagon + "=" + (nas[numberWagon-1]));
}*/


// Крестики нолики

using System;

namespace ConsoleApplication55
{
	class Program
	{

		enum Cell
		{
			СrossX,
			ZeroO
		}
		enum Step
		{
			UserOne,
			UserTwo
		}
		static void Main(string[] args)
		{

			#region Создание поля игры
			int fieldSize = 3;

			Cell[,]  fildOne = new Cell[fieldSize, fieldSize];

			int coordI, coordJ;
			bool inputResutCorrdI, inputResutCorrdJ;

			Step currentStepOne = Step.UserOne;	
			Step currentStepTwo = Step.UserTwo;	
			#endregion

			#region Заполнение полей пустотой
			for (int i = 0; i < fieldSize; i++)
			{
				for (int j = 0; j < fieldSize; j++)
				{
					fildOne[i, j] = Cell.СrossX;
				}
			}
			#endregion

			#region Игравой цикл
			switch (currentStepOne)
			{
				case Step.UserOne:
					Console.WriteLine("USER STEP NOW");
					do
					{
						Console.Write("Input coord I: ");
						inputResutCorrdI = int.TryParse(Console.ReadLine(), out coordI);

						Console.Write("Input coord J: ");
						inputResutCorrdJ = int.TryParse(Console.ReadLine(), out coordJ);

					} while (inputResutCorrdI == false || inputResutCorrdJ == false || coordI - 1 < 0 || coordI - 1 > fieldSize - 1 || coordJ - 1 < 0 || coordJ - 1 > fieldSize - 1);

					if (fildOne[coordI - 1, coordJ - 1] == Cell.ZeroO)
					{
						fildOne[coordI - 1, coordJ - 1] = Cell.СrossX;
					}
					else if (fildOne[coordI - 1, coordJ - 1] == Cell.СrossX)
					{
						fildOne[coordI - 1, coordJ - 1] = Cell.ZeroO;
						currentStepOne = Step.UserTwo;
					}
					break;
				default:
					break;
			}
			#endregion
		}


}
}