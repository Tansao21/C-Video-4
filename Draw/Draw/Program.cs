using Draw;
using System;

Random random = new Random();

int rows, cols;
FieldDraw[,] field;

while (true)
{
	rows =  random.Next((int)Constract.MinRows, (int)Constract.MaxRows - 1);
	cols = random.Next((int)Constract.MinCols, (int)Constract.MaxCols - 1);

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


