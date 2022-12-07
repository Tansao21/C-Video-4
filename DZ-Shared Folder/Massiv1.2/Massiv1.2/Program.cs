// Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.

/*int[] num =  {1,2,-3,4,5,-8,90,23,-45,-67};

for (int i = 0; i < num.Length; i++)
{
	if (num[i] > 0)
	{
		Console.WriteLine(num[i]);
	}
}*/

/*for (int i = 0; i < num.Length; i++)
{
	if (num[i] < 0)
	{
		Console.WriteLine(num[i]);
	}
}*/



//Дан массив целых чисел. Найти номера элементов оканчевающихся цифрой 0 ( известно что такие элементы в массиве есть)

/*int[] mas= {10, 20,32,23,12,31,45,50,70,90,100 };

for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] % 10 == 0)
	{
		Console.WriteLine(i);
	}
}*/



//Дан массив вещественных чисел. Каждый элемент, больший 10, заменить его квадратным корнем.


int[] mas = { 0, 2, 3, 2, 12, 3, 45, 5, 70, 9, 100 };
double num = 0;



/*for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] > 10)
	{
	 num = Math.Sqrt(mas[i]);
	Console.WriteLine($"{i} {num}");
	}
}*/
//for (int i = 0; i < mas.Length; i++) Console.WriteLine($"{i} { mas[i]}");


// Дан массив. Найти: Сумму элементов массива, значение которыфх не привышает 20.

/*int sum = 0;
for (int i = 0; i < mas.Length; i++)
{
	sum += mas[i];
	if (sum < 20)
	{
		Console.WriteLine($"{i}sum {sum}");
	}
}*/


// Рост каждого из 22 учеников класса представлен в виде массиваю Определить количество учеников, рост которых не привышает значения r.

int rost;
int i = 0;
int countStudent = 0;
int[] rostStudent = new int [5];

Console.WriteLine("Введите рост средний: ");
rost= int.Parse(Console.ReadLine());


do
{
	Console.WriteLine("Введите рост учеников: ");
	rostStudent[i] = Convert.ToInt32(Console.ReadLine());

	if (rostStudent[i] < rost)
	{
		countStudent ++;
	}
	i++;
} while (i < 5);

Console.WriteLine($" Колитчество учиников с ростом не привышает {rost} - {countStudent}");