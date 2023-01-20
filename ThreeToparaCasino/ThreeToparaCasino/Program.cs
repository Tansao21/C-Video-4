int userBill = 100;
int InputNumRub()
{
	bool toGo = true;
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
int numRub = InputNumRub();

int[] casino = new int[3];

void CasinoArray(int[] casino)
{
	Random rnd = new Random();
	for (int i = 0; i < casino.Length; i++)
	{
		casino[i] = rnd.Next(1, 9 + 1);
	}
}

void OutputCasinoArray(int[] casino)
{
	for (int i = 0; i < casino.Length; i++)
	{
		Console.Write($"{casino[i]}\t");
	}
}

int ThreeSeven(int[] casino, int numRubNew, int numRub)
{
	 numRubNew = 0;

	if (casino[0] == 7 && casino[1] == 7 && casino[2] == 7)
	{
		numRubNew = numRub * 100;
	}
	return numRubNew;
}

int ThreeSix(int[] casino, int numRubOne, int numRub)
{
	numRubOne = 0;

	if (casino[0] == 6 && casino[1] == 6 && casino[2] == 6)
	{
		numRubOne = numRub * 100;
	}
	return numRubOne;
}

int DoubleСombination(int[] casino, int numRubTwo, int numRub)
{
	numRubTwo = 0;
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
		numRubTwo = numRub * 5;
	}
	return numRubTwo;
}


void CasinoGame(int[] casino, int numRubNew, int numRubOne, int numRubTwo, int numRub)
{
	int userBillNew = 0;
	userBill -= numRub;

	for (int i = 0; i < casino.Length; i++)
	{
		ThreeSeven( casino,  numRubNew,  numRub);
		ThreeSix(casino, numRubOne,  numRub);
		DoubleСombination(casino, numRubTwo,  numRub);
	}
	Console.WriteLine();
}

void Output(int[] casino, int numRubNew, int numRubOne, int numRubTwo, int numRub)
{
	ThreeSeven(casino, numRubNew, numRub);
	ThreeSix(casino, numRubOne, numRub);
	DoubleСombination(casino, numRubTwo, numRub);
	if (ThreeSeven(casino, numRubNew,  numRub) > 0)
	{
		Console.Write("Джек под! Три топора!!!");
		Console.WriteLine($"Ваш выигрыш составил: {ThreeSeven(casino, numRubNew,  numRub)} \n");
		userBill += ThreeSeven(casino, numRubNew,  numRub);
	}

	if (ThreeSix(casino, numRubOne,  numRub) > 0)
	{
		Console.Write("Джек под! Число сатаны!!!");
		Console.WriteLine($"Ваш выигрыш составил: {ThreeSix(casino, numRubOne,  numRub)}\n");
		userBill += ThreeSix(casino, numRubOne,  numRub);
	}

	if (DoubleСombination(casino, numRubTwo, numRub) > 0)
	{
		Console.WriteLine("Мини выиграш!");
		Console.WriteLine("----------------");
		Console.Write($"Ваш выигрыш составил: {DoubleСombination(casino, numRubTwo,  numRub)}\n");
		userBill += DoubleСombination(casino, numRubTwo,  numRub);
	}

	Console.Write($"Ваш счет: {userBill}\n");
	Console.Write($"Для продолжения нажмите Enter!\n");
	Console.ReadLine();
	Console.Clear();
}

void GameNew(int numRub)
{
	if (numRub > userBill)
	{
		Console.WriteLine("Ставку больше лицевого счета произвести нельзя!!!");
	}

}

void ExsitGame ()
{
	bool toGo = true;
	if (userBill == 0)
	{
		
		Console.Write("----------------");
		Console.WriteLine("Ваш баланс  0, пополните!");
		toGo = false;
	}
}




do
{

	CasinoArray(casino);
	OutputCasinoArray(casino);
	CasinoGame(casino, numRubNew, numRubOne, numRubTwo, numRub);
	Output(casino, numRubNew, numRubOne, numRubTwo, numRub);   //numRubNew, numRubOne, numRubTwo,numRub
	GameNew(numRub);
	InputNumRub();
	ExsitGame();
} while (true);



