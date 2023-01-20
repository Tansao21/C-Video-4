
Random rnd = new Random();

int[] casino = new int[3];


int userBill = 100;
bool toGo = true;
int InputNumRub()
{
	int numRub = 0;

	try
	{
		Console.WriteLine($"Ваш лицевой счет: {userBill}");

		Console.WriteLine("----------------");

		Console.WriteLine("Введите вашу ставку: ");
		numRub = int.Parse(Console.ReadLine());

		Console.WriteLine("----------------");


	}
	catch
	{
		toGo = false;
		Console.WriteLine("Не работает программа извените!");
	}
	return numRub;
}

int inputNumRub = InputNumRub();


void CasinoArray()
{
	for (int i = 0; i < casino.Length; i++)
	{
		casino[i] = rnd.Next(1, 9 + 1);
	}

}
void OutputCasinoArray()
{
	for (int i = 0; i < casino.Length; i++)
	{
		Console.Write($"{casino[i]}\t");
	}
}

int ThreeSeven()
{
	int numRubNew = 0;

	if (casino[0] == 7 && casino[1] == 7 && casino[2] == 7)
	{
		numRubNew = inputNumRub * 100;
	}
	return numRubNew;
}

int ThreeSix()
{
	int numRubOne = 0;

	if (casino[0] == 6 && casino[1] == 6 && casino[2] == 6)
	{
		numRubOne = inputNumRub * 100;
	}
	return numRubOne;
}

int DoubleСombination()
{
	int numRubTwo = 0;
	if (casino[0] == 9 && casino[1] == 9 || casino[1] == 9 && casino[2] == 9 ||
			casino[0] == 8 && casino[1] == 8 || casino[1] == 8 && casino[2] == 8 ||
			casino[0] == 7 && casino[1] == 7 || casino[1] == 7 && casino[2] == 7 ||
			casino[0] == 6 && casino[1] == 6 || casino[1] == 6 && casino[2] == 6 ||
			casino[0] == 5 && casino[1] == 5 || casino[1] == 5 && casino[2] == 5 ||
			casino[0] == 4 && casino[1] == 4 || casino[1] == 4 && casino[2] == 4 ||
			casino[0] == 3 && casino[1] == 3 || casino[1] == 3 && casino[2] == 3 ||
			casino[0] == 2 && casino[1] == 2 || casino[1] == 2 && casino[2] == 2 ||
			casino[0] == 1 && casino[1] == 1 || casino[1] == 1 && casino[2] == 1)
	{
		numRubTwo = inputNumRub * 10;
	}
	return numRubTwo;
}

void CasinoGame(int numRub)
{
	int userBillNew = 0;

	userBill -= inputNumRub;

	for (int i = 0; i < casino.Length; i++)
	{
		ThreeSeven();
		ThreeSix();
		DoubleСombination();
	}
	Console.WriteLine();
}

void Output()
{
	if (ThreeSeven() > 0)
	{
		Console.Write("Джек под! Три топора!!!");
		Console.WriteLine($"Ваш выигрыш составил: {ThreeSeven()} \n");
		userBill += ThreeSeven();
	}

	if (ThreeSix() > 0)
	{
		Console.Write("Джек под! Число сатаны!!!");
		Console.WriteLine($"Ваш выигрыш составил: {ThreeSix()}\n");
		userBill += ThreeSix();
	}

	if (DoubleСombination() > 0)
	{
		Console.WriteLine("Мини выиграш!");
		Console.WriteLine("----------------");
		Console.Write($"Ваш выигрыш составил: {DoubleСombination()}\n");
		userBill += DoubleСombination();
	}

	Console.Write($"Ваш счет: {userBill}\n");
	Console.Write($"Для продолжения нажмите Enter!\n");
	Console.ReadLine();
	Console.Clear();
}

void GameNew()
{
	if (inputNumRub > userBill)
	{
		Console.WriteLine("Ставку больше лицевого счета произвести нельзя!!!");
	}

}

void ExsitGame ()
{
	if (userBill == 0)
	{
		
		Console.Write("----------------");
		Console.WriteLine("Ваш баланс  0, пополните!");
		toGo = false;
	}
}
	
do
{
	CasinoArray();
	OutputCasinoArray();
	ThreeSeven();
	ThreeSix();
	DoubleСombination();
	CasinoGame(inputNumRub);
	Output();
	GameNew();
	ExsitGame();
	InputNumRub();
} while (!toGo);

