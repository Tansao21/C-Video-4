//поле - двумерный массив размера N на M
//портал - объект, пренадлежит полю
//стены - объекты, прендалежат полю, по краям поля сделать стены
//герой - объект, НЕ пренадлежит полю, рисуется поверх полю

//1) генерация поля и стен на нём
//2) генерация портала в поле (перандомировать поле если мы оказались заперты)
//3) передвижение героя по полю
//4) вход героя в портал и переход к шагу 1



using MyHeroGame;

Random random = new Random();

int levelGame = 1;
int rowsN, colsM;
Cell[,] field;

int iHero, jHero;


int countWallNumb = (int)Constants.WallCount;

bool hero;


while (true)
{
	rowsN = random.Next((int)Constants.MinRows, (int)Constants.MaxRows - 1);
	colsM = random.Next((int)Constants.MinCols, (int)Constants.MaxCols - 1);


	field = new Cell[rowsN, colsM];

	for (int i = 0; i < rowsN; i++)  //вывод пустых полей
	{
		for (int j = 0; j < colsM; j++)
		{
			field[i, j] = Cell.Empty;
		}
	}

	for (int i = 0; i < rowsN; i++) // вывод границ
	{
		field[i, 0] = Cell.Bound;
		field[i, colsM - 1] = Cell.Bound;
	}

	for (int j = 0; j < colsM; j++) // задали границам карайнии точки
	{
		field[0, j] = Cell.Bound;
		field[rowsN - 1, j] = Cell.Bound;
	}


	// Задаем начальные точки появления героя
	iHero = (int)Constants.StartHeroI;
	jHero = (int)Constants.StartHeroJ;

	// Задаем стартовые точки собаки
	int iDog = (int)Constants.StartDodI;
	int jDog = (int)Constants.StartDodJ;

	//Создаем портал

	int iPortal, jPortal;

	do
	{
		iPortal = random.Next(1, rowsN - 1);
		jPortal = random.Next(1, colsM - 1);
	} while (iPortal == iHero && jPortal == jHero);

	field[iPortal, jPortal] = Cell.Portal;


	//Создаем количество преград
	int countWall = (int)((rowsN - 2) * (colsM - 2) * countWallNumb / 100.0);
	for (int i = 0; i < countWall; i++)
	{
		int iWall, jWall;
		do
		{
			iWall = random.Next(1, rowsN - 1);
			jWall = random.Next(1, colsM - 1);
		} while (iWall == iHero && jWall == jHero || field[iWall, jWall] == Cell.Portal || field[iWall, jWall] == Cell.Wall);

		field[iWall, jWall] = Cell.Wall;
	}

	//
	bool dog = true;
	while (dog)
	{
		Console.Clear();

		Console.ResetColor();


		Console.WriteLine($"Level Game = {levelGame}");

		for (int i = 0; i < rowsN; i++)
		{
			for (int j = 0; j < colsM; j++)
			{
				if (i == iHero && j == jHero)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine((char)Constants.DogSkin);
				}
				Console.Write((char)field[i, j]);
			}
			Console.WriteLine();
		}
		dog = false;
	}

	//


	// поставили флажок как истина
	hero = true;
	while (hero)
	{
		Console.Clear(); 

		Console.ResetColor();
	

		Console.WriteLine($"Level Game = {levelGame}");

	for (int i = 0; i < rowsN; i++)
	{
		for (int j = 0; j < colsM; j++)
		{
			if (i == iHero && j == jHero)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine((char)Constants.HeroSkin);
			}
			else
			{
				switch (field[i,j])
				{
					case Cell.Empty:
						Console.ForegroundColor = ConsoleColor.Gray;
						break;
					case Cell.Wall:
						Console.ForegroundColor = ConsoleColor.DarkRed;
						break;
					case Cell.Portal:
						Console.ForegroundColor = ConsoleColor.Blue;
						break;
					case Cell.Bound:
						Console.ForegroundColor = ConsoleColor.Green;
						break;
				}
				Console.Write((char)field[i, j]);
			}
		}
		Console.WriteLine();
	}

	ConsoleKey key = Console.ReadKey(false).Key;
	switch (key)
	{
		case ConsoleKey.A:
			if (field[iHero, jHero - 1] == Cell.Empty || field[iHero, jHero - 1] == Cell.Portal)
			{
				jHero--;
				}

			break;

		case ConsoleKey.W:
			if (field[iHero - 1, jHero] == Cell.Empty || field[iHero - 1, jHero] == Cell.Portal)
			{
				iHero--;
				}

			break;

		case ConsoleKey.D:
			if (field[iHero, jHero + 1] == Cell.Empty || field[iHero, jHero + 1] == Cell.Portal)
			{
				jHero++;
				}

			break;

		case ConsoleKey.S:
			if (field[iHero + 1, jHero] == Cell.Empty || field[iHero + 1, jHero] == Cell.Portal)
			{
				iHero++;
			}

			break;

		case ConsoleKey.R:
			levelGame = 0;
			hero = false;
			break;
	}

	if (field[iHero, jHero] == Cell.Portal)
	{
		levelGame++;
		countWallNumb += 5;
		hero = false;
	}
}
}



