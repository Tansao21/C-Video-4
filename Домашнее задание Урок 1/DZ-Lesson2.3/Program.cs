﻿//В прошлом году Вася пошел в школу и научился считать. В этом году он изучил таблицу умножения и теперь умеет перемножать любые числа от 1 до 10 без ошибок. Друг Петя рассказал ему про системы счисления, отличные от десятичной. В частности, про двоичную, восьмеричную и даже шестнадцатеричную. Теперь Вася без труда (но уже с помощью листка и ручки) может перемножать числа от 1 до 10 и в этих системах, используя перевод из нестандартной системы в десятичную и обратно из десятичной. Например, если Васе нужно перемножить числа 101 и 1001 в двоичной системе, то он сначала эти числа переводит в десятичное представление следующим образом:

//(101)2 = 1 * 22 + 0 * 21 + 1 * 20 = 4 + 0 + 1 = 5

//(1001)2 = 1 * 23 + 0 * 22 + 0 * 21 + 1 * 20 = 8 + 0 + 0 + 1 = 9

//После чего перемножение чисел 5 и 9 Вася с легкостью производит в десятичной системе счисления в уме и получает число 45. Далее производится перевод из десятичной системы счисления в двоичную. Для этого Вася делит число 45 на 2 (порядок системы счисления), запоминая остатки от деления, до тех пор пока в результате не останется число 0:

//Первод из десятичной системы счисления в двоичную
//Ответ составляется из полученных остатков от деления путем их записи в обратном порядке. Таким образом Вася получает результат: (101)2 * (1001)2 = (101101)2.Но теперь Вася изучает таблицу умножения чисел от 1 до 100 в десятичной системе счисления, а поскольку запомнить такую таблицу очень сложно, то Васе придется очень долго ее зубрить. Составьте для Васи программу, которая поможет ему проверять свои знания.

//Входные данные
//Во входном файле INPUT.TXT записаны три натуральных числа A, B и C через пробел. Числа A и B ≤ 102, а C ≤ 106.

//Выходные данные
//В выходной файл нужно вывести YES в том случае, если A*B=C и вывести NO в противном случае.

int numberA;
int numberB;
int numberC;
int number = 10;
Console.Write("Введите число А: ");
numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
numberB = int.Parse(Console.ReadLine());

Console.Write("Введите число C: ");
numberC = int.Parse(Console.ReadLine());



/*if (numberA <= Math.Pow(number, 2) && numberB <= Math.Pow(number, 2) && numberC <= Math.Pow(number, 6))
{
	int k = numberA * numberB;
		
	if(k == numberC)
	{
		Console.WriteLine("YES!!!!");
	}
	else
	{
		Console.WriteLine("No!!!");
	}
}*/

if (numberA * numberB == numberC)
{
	Console.WriteLine("YES!!!!");
}
else
{
	Console.WriteLine("No!!!");
}