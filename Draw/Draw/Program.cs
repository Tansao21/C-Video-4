using Draw;

FieldDraw[,] Field(int rows, int cols)
{
	return new FieldDraw[rows, cols];
}


int Rows ()
{
	Console.WriteLine($"Введите количество строк по оси X: ");
	int rows = int.Parse(Console.ReadLine());
	return rows;
}

int Cols ()
{
	Console.WriteLine($"Введите количество столбцов по оси Y: ");
	int cols = int.Parse(Console.ReadLine());
	return cols;
}

void CreatingField(FieldDraw[,] field, int rows, int cols)
{
  
	 field = new FieldDraw[rows, cols];

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

static void ResetConsole()
{
	Console.Clear();
	Console.ResetColor();
}

void FieldBoundaries(FieldDraw[,] field, int rows, int cols, int startIPencil, int startJPencil)
{
	ResetConsole();

	field = new FieldDraw[rows, cols];

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < cols; j++)
		{
			if (i == startIPencil && j == startJPencil)
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

void CursorMovement (FieldDraw[,] field, int startIPencil, int startJPencil)
{
	bool heroInAdventure = true;

	ConsoleKey key = Console.ReadKey(false).Key;
	switch (key)
	{
		case ConsoleKey.A:
			if (field[startIPencil, startJPencil - 1] == FieldDraw.Empty || field[startIPencil, startJPencil - 1] == FieldDraw.Empty)
			{
				startJPencil--;
			}

			break;

		case ConsoleKey.W:
			if (field[startIPencil - 1, startJPencil] == FieldDraw.Empty || field[startIPencil - 1, startJPencil] == FieldDraw.Empty)
			{
				startIPencil--;
			}

			break;

		case ConsoleKey.D:
			if (field[startIPencil, startJPencil + 1] == FieldDraw.Empty || field[startIPencil, startJPencil + 1] == FieldDraw.Empty)
			{
				startJPencil++;
			}

			break;

		case ConsoleKey.S:
			if (field[startIPencil + 1, startJPencil] == FieldDraw.Empty || field[startIPencil + 1, startJPencil] == FieldDraw.Empty)
			{
				startIPencil++;

			}

			break;

		case ConsoleKey.R:
			heroInAdventure = false;
			break;
	}
} 




while (true)
{
	int rows =Rows();
	int cols = Cols();

	FieldDraw[,] field = Field(rows, cols);


	int startJPencil = (int)Constract.StartJPencil;
	int startIPencil = (int)Constract.StartIPencil;

	FieldBoundaries(field, rows, cols,  startIPencil, startJPencil);
	CreatingField(field, rows, cols);




	CursorMovement(field, startIPencil, startJPencil);

}

