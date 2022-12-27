//сделать сравнение 2х длинных чисел
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

// не могу сделать крестики нолики не понимаю что к чему даже подсматривая код с морского боя((((!

int column = 3;
int str = 3;
int stepX, stepY, step;
int count = 0;
int countO = 0;
int countX = 0;
int vonO, vonX;

string[,] mas = new string[str, column];

for (int i = 0; i < str; i++)
{
	for (int j = 0; j < column; j++)
	{
		mas[i, j] = "*";
	}
}

for (int k = 0; k < str; k++)
{
	for (int j = 0; j < column; j++)
	{
		Console.Write(mas[k, j] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine("Введите координату клетки для хода X");
step = int.Parse(Console.ReadLine()) - 1;
mas[step / 3, step % 3] = "X";
Console.Clear();

while (countX + countO < 8)
{
	for (int k = 0; k < str; k++)
	{
		for (int j = 0; j < column; j++)
		{
			Console.Write(mas[k, j] + " ");
		}
		Console.WriteLine();
	}
	Console.WriteLine("Введите координату клетки для хода X");
	step = int.Parse(Console.ReadLine()) - 1;
	countO++;
	mas[step / 3, step % 3] = "O";
	Console.Clear();
	if (mas[0, 0] == "O" && mas[0, 1] == "O" && mas[0, 2] == "O" ||
		mas[1, 0] == "O" && mas[1, 1] == "O" && mas[1, 2] == "O" ||
		mas[2, 0] == "O" && mas[2, 1] == "O" && mas[2, 2] == "O" ||
		mas[0, 0] == "O" && mas[1, 0] == "O" && mas[2, 0] == "O" ||
		mas[0, 1] == "O" && mas[1, 1] == "O" && mas[2, 1] == "O" ||
		mas[0, 2] == "O" && mas[1, 2] == "O" && mas[2, 2] == "O" ||
		mas[0, 0] == "O" && mas[1, 1] == "O" && mas[2, 2] == "O" ||
		mas[0, 2] == "O" && mas[1, 1] == "O" && mas[2, 0] == "O")
	{
		Console.WriteLine("Выйграли O");
		countO += 5;
		for (int k = 0; k < str; k++)
		{
			for (int j = 0; j < column; j++)
			{
				Console.Write(mas[k, j] + " ");
			}
			Console.WriteLine();
		}
	}

	if (countO + countX <= 8)
	{
		for (int k = 0; k < str; k++)
		{
			for (int j = 0; j < column; j++)
			{
				Console.Write(mas[k, j] + " ");
			}
			Console.WriteLine();
		}

		Console.WriteLine("Введите координату клетки для хода O");
		step = int.Parse(Console.ReadLine()) - 1;
		mas[step / 3, step % 3] = "X";
		Console.Clear();
	}

	if (countO + countX <= 8)
	{
		for (int k = 0; k < str; k++)
		{
			for (int j = 0; j < column; j++)
			{
				Console.Write(mas[k, j] + " ");
			}
			Console.WriteLine();
		}
		countX++;
		Console.Clear();
	}

	if (mas[0, 0] == "X" && mas[0, 1] == "X" && mas[0, 2] == "X" ||
		mas[1, 0] == "X" && mas[1, 1] == "X" && mas[1, 2] == "X" ||
		mas[2, 0] == "X" && mas[2, 1] == "X" && mas[2, 2] == "X" ||
		mas[0, 0] == "X" && mas[1, 0] == "X" && mas[2, 0] == "X" ||
		mas[0, 1] == "X" && mas[1, 1] == "X" && mas[2, 1] == "X" ||
		mas[0, 2] == "X" && mas[1, 2] == "X" && mas[2, 2] == "X" ||
		mas[0, 0] == "X" && mas[1, 1] == "X" && mas[2, 2] == "X" ||
		mas[0, 2] == "X" && mas[1, 1] == "X" && mas[2, 0] == "X")
	{
		Console.WriteLine("Выйграли X");
		countX += 5;
		for (int k = 0; k < str; k++)
		{
			for (int j = 0; j < column; j++)
			{
				Console.Write(mas[k, j] + " ");
			}
			Console.WriteLine();
		}
	}
}

if (countX + countO == 8)
{
	Console.WriteLine("Нету выйгрывшых комбинаций");
	for (int k = 0; k < str; k++)
	{
		for (int j = 0; j < column; j++)
		{
			Console.Write(mas[k, j] + " ");
		}
		Console.WriteLine();
	}
	Console.ReadLine();
}
