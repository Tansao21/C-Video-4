//Белочка собрала в лесу N шишек c орешками. Белочка очень привередливо выбирала шишки, и брала только те, в которых ровно M орешков. Также известно, что для пропитания зимой ей необходимо не менее K орешков. Определите, хватит ли на зиму орешков белочке.

//Входные данные
//Первая строка входного файла INPUT.TXT содержит три натуральных числа через пробел: N, M и K (N, M ≤ 100, K ≤ 10 000).

//Выходные данные
//В выходной файл OUTPUT.TXT выведите «YES» если белочке хватит орешков и «NO» в противном случае.


int numberCones;
int numberNuts;
int countNuts;


Console.Write("Введите число шишек: ");
numberCones = int.Parse(Console.ReadLine());

Console.Write("Введите число орешков: ");
numberNuts = int.Parse(Console.ReadLine());

Console.Write("Введите количество орешков на зиму: ");
countNuts = int.Parse(Console.ReadLine());


if(numberCones * numberNuts >= countNuts)
{
	Console.WriteLine("Белке хватает! YES!");
}
else
{
	Console.WriteLine("Белке не хватает! NO!");
}
Console.ReadKey();