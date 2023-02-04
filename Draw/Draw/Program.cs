using Draw;
using System;
using System.Drawing;

FieldDraw[,] CreateField(int rows, int cols)
{
	return new FieldDraw[rows, cols];
}


int InputRows()
{
	Console.WriteLine($"Введите количество строк по оси X: ");
	int rows = int.Parse(Console.ReadLine());
	return rows;
}

int InputCols()
{
	Console.WriteLine($"Введите количество столбцов по оси Y: ");
	int cols = int.Parse(Console.ReadLine());
	return cols;
}

void FillField(FieldDraw[,] field)
{
	int rows = field.GetLength(0);
	int cols = field.GetLength(1);

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
		{
			field[i, j] = FieldDraw.Empty;
		}
	}

	for (int i = 0; i < rows; i++)
	{
		field[i, 0] = FieldDraw.Bound;
		field[i, cols - 1] = FieldDraw.Bound;
	}

	for (int j = 0; j < cols; j++)
	{
		field[0, j] = FieldDraw.Bound;
		field[rows - 1, j] = FieldDraw.Bound;
	}
}



void FieldBoundaries(FieldDraw[,] field, int iPencil, int jPencil)
{
	int rows = field.GetLength(0);
	int cols = field.GetLength(1);

	Console.ResetColor();
	Console.Clear();

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
		{
			if (i == iPencil && j == jPencil)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write((char)Constract.PencilSkin);
			}
			else
			{
				switch (field[i, j])
				{
					case FieldDraw.Empty:
						Console.ForegroundColor = ConsoleColor.Red;
						break;
					case FieldDraw.Bound:
						Console.ForegroundColor = ConsoleColor.Green;
						break;
				}

				Console.Write((char)field[i, j]);
			}
		}

		Console.WriteLine();
	}
}


void Zacrasca(FieldDraw[,] field, ColorDraw colors, ConsoleKey key)
{
	int rows = field.GetLength(0);
	int cols = field.GetLength(1);

	switch (key)
	{
		case ConsoleKey.Q:
			if (colors.ColorOne == 'Q')
			{
				field[rows, cols] = FieldDraw.Empty;
				Console.ForegroundColor = ConsoleColor.Green;
			}
			break;
		case ConsoleKey.Z:
			if (colors.ColorOne == 'Z')
			{
				field[rows, cols] = FieldDraw.Empty;
				Console.ForegroundColor = ConsoleColor.Blue;
			}
			break;

		case ConsoleKey.X:
			if (colors.ColorOne == 'X')
			{
				field[rows, cols] = FieldDraw.Empty;
				Console.ForegroundColor = ConsoleColor.Magenta;
			}
			break;
		case ConsoleKey.C:
			if (colors.ColorOne == 'C')
			{
				field[rows, cols] = FieldDraw.Empty;
				Console.ForegroundColor = ConsoleColor.Yellow;
			}
			break;

		case ConsoleKey.V:
			if (colors.ColorOne == 'V')
			{
				field[rows, cols] = FieldDraw.Empty;
				Console.ForegroundColor = ConsoleColor.Red;
			}
			break;

	}
}

void CursorMovement(FieldDraw[,] field, ColorDraw colors, ConsoleKey key, ref int iPencil, ref int jPencil)
{
	int rows = field.GetLength(0);
	int cols = field.GetLength(1);

	

	switch (key)
	{
		case ConsoleKey.A:
			if (jPencil > 1)
			{
				jPencil--;
			}

			break;

		case ConsoleKey.W:
			if (iPencil > 1)
			{
				iPencil--;
			}

			break;

		case ConsoleKey.D:
			if (jPencil < cols - 2)
			{
				jPencil++;
			}
			break;

		case ConsoleKey.S:
			if (iPencil < rows - 2)
			{
				iPencil++;
			}
			break;

		case ConsoleKey.Spacebar:
			field[iPencil, jPencil] = FieldDraw.Bound;
			break;

		case ConsoleKey.Backspace:
			field[iPencil, jPencil] = FieldDraw.Empty;
			break;
	}
}

void InputMenu()
{
	Console.WriteLine("Выберите цвет!");

	Console.WriteLine("Q. Цвет зеленый");
	Console.WriteLine("Z. Цвет синий");
	Console.WriteLine("X. Цвет розовый");
	Console.WriteLine("C. Цвет желтый");
	Console.WriteLine("V. Цвет красный");

	Console.ReadKey();
}

 void ColorDrawInit(ColorDraw colors) 
{
	colors.ColorOne = 'Q';
	colors.ColorTwo = 'Z';
	colors.ColorThree = 'X';
	colors.ColorFour = 'C';
	colors.ColorFive = 'V';
} 


int rows = InputRows();
int cols = InputCols();
InputMenu();

FieldDraw[,] field = CreateField(rows, cols);
FillField(field);

int jPencil = (int)Constract.StartJPencil;
int iPencil = (int)Constract.StartIPencil;

ColorDraw colors = new ColorDraw();
ColorDrawInit(colors);

while (true)
{



	FieldBoundaries(field, iPencil, jPencil);


	ConsoleKey key = Console.ReadKey(false).Key;
	CursorMovement(field, colors, key, ref iPencil, ref jPencil);
	Zacrasca(field, colors, key);

	
}