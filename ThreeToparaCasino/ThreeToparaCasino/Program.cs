
Random rnd = new Random();

int[] casino = new int[3];




bool toGo = true;
int userBill = 100;
do
{
	try
	{

		Console.WriteLine($"Ваш лицевой счет: {userBill}");
		int userBillNew = 0;
		int numRubNew = 0;
		int numRubTwo = 0;
		int numRubOne = 0;

		Console.WriteLine("----------------");

		Console.WriteLine("Введите вашу ставку: ");
		int numRub = int.Parse(Console.ReadLine());

		Console.WriteLine("----------------");

		userBill -= numRub;

		for (int i = 0; i < casino.Length; i++)
		{
			casino[i] = rnd.Next(1, 9 + 1);
		}

		for (int i = 0; i < casino.Length; i++)
		{
			Console.Write($"{casino[i]}\t");
		}


		for (int i = 0; i < casino.Length; i++)
		{
			
			if (casino[0] ==7 && casino[1] == 7 && casino[2]== 7 || 
				casino[0] == 6 && casino[1] == 6 && casino[2] == 6)
			{
				numRubNew = numRub * 100 + userBill;
			}

			if (casino[0] == 6 && casino[1] == 6 && casino[2] == 6)
			{
				numRubOne = numRub * 100 + userBill;
			}

			if (casino[0] == 6 && casino[1] == 6 || casino[1] == 6 && casino[2] == 6 ||
				casino[0] == 5 && casino[1] == 5 || casino[1] == 5 && casino[2] == 5 ||
				casino[0] == 4 && casino[1] == 4 || casino[1] == 4 && casino[2] == 4 ||
				casino[0] == 3 && casino[1] == 3 || casino[1] == 3 && casino[2] == 3 ||
				casino[0] == 2 && casino[1] == 2 || casino[1] == 2 && casino[2] == 2 ||
				casino[0] == 1 && casino[1] == 1 || casino[1] == 1 && casino[2] == 1)
			{
				numRubTwo = numRub * 10 + userBill;
			}
		}

		// Добавил три этих ифа и переприсвоил значение Вашего счета
		if (numRubNew > 0)
		{
			Console.Write("Джек под! Три топора!!!");
			Console.WriteLine($"Ваш выигрыш составил: {numRubNew}");
			userBill += numRubNew;
		}
		if (numRubOne > 0)
		{
			Console.Write("Джек под! Число сатаны!!!");
			Console.WriteLine($"Ваш выигрыш составил: {numRubNew}");
			userBill += numRubOne;
		}
		if (numRubTwo > 0)
		{
			Console.Write("Мини выиграш!");
			Console.WriteLine("----------------");
			Console.Write($"Ваш выигрыш составил: {numRubTwo}");
			userBill += numRubTwo;
		}


		if (userBill == 0)
		{
			Console.Write("----------------");
			Console.WriteLine("Ваш баланс  0, пополните!");
			toGo = false;
		}
		Console.WriteLine();
		Console.WriteLine($"Ваш счет: {userBill}");
			
		Console.ReadLine();
		Console.Clear();
	}
	catch
	{
		toGo = false;
		Console.WriteLine("Не работает программа извените!");
	}

} while (toGo);