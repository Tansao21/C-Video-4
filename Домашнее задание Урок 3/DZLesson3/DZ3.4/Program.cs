// Напишите таблицу умножения на 9:
int i = 1; 
int multipl = 9;

while (i <= multipl)
{
	int tabl = i * multipl;
	Console.WriteLine($"{multipl} * {i} = {tabl}");
	i++;
}

