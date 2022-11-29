// дана последовательность из 10 чисел которые вводит пользователь (пользователь вводит любые числа, например 8 1234 46 5 76 6 7 )
// определить что больше раз встречается в этой последовательности число 5 или число 7

int iter = 0;
int number = 10;
int numberFive = 5;
int numberSeven = 7;
int countFive = 0;
int countSeven = 0;
int numberUser = 0;

/*
while (iter < number)
{
Console.Write("Введите числа: ");
numberUser = int.Parse(Console.ReadLine());

	if (numberUser == numberFive)
	{
		countFive++;
	}
	if (numberUser == numberSeven)
	{
		countSeven++;
	}
	iter++;
}

	if (countFive > countSeven)
	{
		Console.WriteLine($"Число 5  встечается {countFive}");
	}
	else
	{
		Console.WriteLine($"Число 7  встечается {countSeven}");
	}*/



do
{
	Console.Write("Введите числа: ");
	numberUser = int.Parse(Console.ReadLine());

	if (numberUser == numberFive)
	{
		countFive++;
	}
	if (numberUser == numberSeven)
	{
		countSeven++;
	}
	iter++;

} while (iter < number);

if (countFive > countSeven)
{
	Console.WriteLine($"Число 5  встечается {countFive}");
}
else if (countFive < countSeven)
{
	Console.WriteLine($"Число 7  встечается {countSeven}");
}
else
{
	Console.WriteLine($"Число 7 и 5 встечается {countSeven} = {countFive}");
}



/*int i = 0;
int num = 0;
int count5 = 0;
int count7 = 0;
while (i < 10)
{
	Console.Write("Введите числа: ");
	num = int.Parse(Console.ReadLine());
	if (num == 5)
	{
		count5++;
	}
	if (num == 7)
	{
		count7++;
	}
	i++;
}

if (count5 > count7)
{

	Console.WriteLine("Число 5 больше встечается ");
}
else
{
	Console.WriteLine("Число 7 больше встечается ");
}*/