//Напечатать таблицу перевода 1,2, .... 20 долларов США в рубли по теккущеу курсу ( значения курса вводиться с клавиатуры).
int i;
int dolars = 1;
int cursDolarsRub;

Console.Write("Введите курс доллора: ");
cursDolarsRub = int.Parse(Console.ReadLine());

i = dolars;

while (i <= 20)
{
	int rubs = i * cursDolarsRub;
	Console.WriteLine($"{i} $ - {rubs} Руб.,");
	i++;
}
