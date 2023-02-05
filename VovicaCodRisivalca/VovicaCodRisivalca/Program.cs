using System;
using System.Drawing;

namespace PixelArt
{
	public enum Cell
	{
		Empty = '*',
		Bound = '#',
		PixSkin = '֍'  // 1421	U+058D	D6 8D
	}

	public struct Pixel
	{
		public Cell symbol;
		public ConsoleColor color;
	}

	public class Program
	{
		static Cell[,] CreateField(int yRows, int xCols) // задаём двумерный массив 
		{
			return new Cell[yRows, xCols];
		}
		static int InitRows() // Спрашиваем сколько строк + возвращаем их
		{
			Console.WriteLine($"Введите количество строк по оси Y: ");
			int yRows = int.Parse(Console.ReadLine());

			return yRows;
		}

		static int InitCols() // Спрашиваем сколько столбцов + возвращаем их
		{
			Console.WriteLine($"Введите количество столбцов по оси X: ");
			int xCols = int.Parse(Console.ReadLine());

			return xCols;
		}

		static void InitField(Cell[,] field) // задаём поле, границы поля по X(i) , Y (j)
		{
			int yRows = field.GetLength(0);
			int xCols = field.GetLength(1);

			for (int i = 0; i < yRows; i++)
			{
				for (int j = 0; j < xCols; j++)
				{
					field[i, j] = Cell.Empty;
				}
			}
			for (int i = 0; i < yRows; i++)
			{
				field[i, 0] = Cell.Bound;
				field[i, xCols - 1] = Cell.Bound;
			}
			for (int j = 0; j < xCols; j++)
			{
				field[0, j] = Cell.Bound;
				field[yRows - 1, j] = Cell.Bound;
			}
		}

		static int InitXPix() // Старт координаты пикселя по X
		{
			int xPix = 1;
			return xPix;
		}

		static int InitYPix() // Старт координаты пикселя по Y

		{
			int yPix = 1;
			return yPix;
		}


		static void PrintObjects(Pixel[,] field, int xPix, int yPix) // отрисовка поля, пикселя, стен, пустот
		{

			int yRows = field.GetLength(0);
			int xCols = field.GetLength(1);

			Console.Clear();
			Console.ResetColor();


			for (int i = 0; i < yRows; i++)
			{
				for (int j = 0; j < xCols; j++)
				{
					if (i == xPix && j == yPix)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write((char)Cell.PixSkin);
					}
					else
					{
						Console.ForegroundColor = field[i, j].color;
						Console.Write((char)field[i, j].symbol);

					}
				}
				Console.WriteLine();
			}

		}

		static void MovePix(Cell[,] field, ref int xPix, ref int yPix)// движение пикселя WASD + Space
		{
			int yRows = field.GetLength(0);
			int xCols = field.GetLength(1);

			ConsoleKey key = Console.ReadKey(false).Key;
			switch (key)
			{
				case System.ConsoleKey.A:
					if (field[xPix, yPix - 1] == Cell.Empty)
					{
						yPix--;
					}
					break;

				case System.ConsoleKey.W:
					if (field[xPix - 1, yPix] == Cell.Empty)
					{
						xPix--;
					}
					break;

				case System.ConsoleKey.D:
					if (field[xPix, yPix + 1] == Cell.Empty)
					{
						yPix++;
					}
					break;

				case System.ConsoleKey.S:
					if (field[xPix + 1, yPix] == Cell.Empty)
					{
						xPix++;
					}
					break;

					/* case System.ConsoleKey.Space
                     if (field[xPix, yPix] == Pixel.symbol && Pixel.symbol == Pixel.color)
                     {
                     }
                    */
			}
		}



		static void PrintMessage()
		{
			Console.WriteLine($"Для добавления цвета и символа нажмите *пробел*: ");
			Console.Clear();
		}
		/*
        void PrintPixel(field[,])
        {
            if (Console.ReadKey(Space))
            {
                field[i, j] == Pixel.symbol && Pixel.symbol == Pixel.color;
            }
        }
        */

		static void ColorPixel(Color color) // Цвет по выбору
		{
			ConsoleKey key = Console.ReadKey(false).Key;
			switch (key)
			{
				case (ConsoleKey)1:
					{
						Console.Write("Введите позицию: ");
						int newColor = int.Parse(Console.ReadLine());
						color = Color.Red;
						Console.ForegroundColor = ConsoleColor.Red;
					}
					break;

				case (ConsoleKey)2:
					{
						Console.Write("Введите позицию: ");
						int newColor = int.Parse(Console.ReadLine());
						color = Color.Blue;
						Console.ForegroundColor = ConsoleColor.Blue;

					}
					break;

				case (ConsoleKey)3:
					{
						Console.Write("Введите позицию: ");
						int newColor = int.Parse(Console.ReadLine());
						color = Color.Green;
						Console.ForegroundColor = ConsoleColor.Green;
					}
					break;
			}

		}


		//------------------------------

		static void Main()
		{

			int yRows = InitRows();
			int xCols = InitCols();

			int xPix = InitXPix();
			int yPix = InitYPix();


			Cell[,] field = CreateField(yRows, xCols);
			

			InitField(field);

			bool play = true;

			while (play)
			{
				PrintObjects(field, xPix, yPix);
				MovePix(field, ref xPix, ref yPix);
			}
		}

		private static void PrintObjects(Cell[,] field, int xPix, int yPix)
		{
			throw new NotImplementedException();
		}
	}
}
