//В отделе работают 3 сотрудника, которые получают заработную плату в рублях. Требуется определить: на сколько зарплата самого высокооплачиваемого из них отличается от самого низкооплачиваемого.

//Входные данные
//В единственной строке входного файла INPUT.TXT записаны размеры зарплат всех сотрудников через пробел. Каждая заработная плата – это натуральное число, не превышающее 105.

//Выходные данные
//В выходной файл OUTPUT.TXT необходимо вывести одно целое число — разницу между максимальной и минимальной зарплатой.



int workerZpOne;
int workerZpTwo;
int workerZpThree;
int maxZp;
int minZp;


Console.Write("Введите зарплату первого рабочего: ");
workerZpOne = int.Parse(Console.ReadLine());

Console.Write("Введите зарплату второго рабочего: ");
workerZpTwo = int.Parse(Console.ReadLine());

Console.Write("Введите зарплату третьего рабочего: ");
workerZpThree = int.Parse(Console.ReadLine());
maxZp = workerZpOne;
minZp = workerZpOne;

if (workerZpTwo > maxZp)
{
	maxZp = workerZpTwo;
	if (workerZpThree > maxZp)
	{
		maxZp = workerZpThree;
	}
}

if (workerZpTwo < maxZp)
{
	maxZp = workerZpTwo;
	if (workerZpThree < maxZp)
	{
		maxZp = workerZpThree;
	}
}


int difference = maxZp - minZp;

Console.WriteLine($"Разница в зарплате состовляет: {difference}");
Console.ReadKey();