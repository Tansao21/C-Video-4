using People;


int id = 0;

#region CreationArray Изменили размер массива
void ResizeArray(ref Human[] humans, int newHumanLength)
{
	int minLength = newHumanLength > humans.Length ? humans.Length : newHumanLength;

	Human[] newHumansArray = new Human[minLength];

	for (int i = 0; i < minLength; i++)
	{
		newHumansArray[i] = humans[i];
	}
	humans = newHumansArray;
}

int InputInt(string message)
{
	bool inputResult;
	int number;

	do
	{
		Console.WriteLine(message);
		inputResult = int.TryParse(Console.ReadLine(), out number);

	} while (!inputResult);
	return number;
}

DateTime InputDateTime(string message)
{
	bool inputResult;
	DateTime dt;

	do
	{

		Console.WriteLine(message);
		inputResult = DateTime.TryParse(Console.ReadLine(), out dt);

	} while (!inputResult);
	return dt;
}

string InputString(string message)
{
	Console.WriteLine(message);
	return Console.ReadLine();
}
#endregion


#region CRUD

#region Add Array
void AddArray(ref Human[] humans, Human human)
{
	if (humans == null)
	{
		humans = new Human[1];
	}
	else
	{
		ResizeArray(ref humans, humans.Length + 1);
	}
	humans[humans.Length - 1] = human;
}
#endregion


#region Filling in the table Заполнение таблицы

Human FillingTabls(Human[] humans, ref int id, bool isNewId)
{
	Human human;
	if (isNewId)
	{
		id++;
		human.Id = id;
	}
	else
	{
		human.Id = 0;
	}

	human.Name = InputString("Введите имя: ");

	human.Surname = InputString("Введит фамилию: "); 

	human.DateOfBirth = InputDateTime("Введите дату рождения: ");

	human.Age = InputInt("Введите возраст: ");

	human.Profession = InputString("Введите профессию: ");

	return human;
}
#endregion

#region Filling Задаем значения заполнения структуры
Human Filling()
{
	Human human;
	human.Id = 0;
	human.Name = "";
	human.Surname = "";
	human.DateOfBirth = DateTime.Now;
	human.Age = 0;
	human.Profession = "";

	return human;
}
#endregion

#region Hat Tabls Шляпа таблицы
void HatTabls(Human human)
{
	Console.WriteLine("{0, -3} {1,-12} {2, -15} {3,-20} {4,-3} {5,-20}", human.Id, human.Name, human.Surname, human.DateOfBirth.ToShortDateString(), human.Age, human.Profession);
}

void PrintHatTabls(Human[] humans)
{
	Console.WriteLine("{0, -3} {1, -12 } {2, -15} {3, -12} {4, -11} {5, -20}", "ИД", "Имя", "Фамилия", "Дата рождения", "Возраст", "Профессия");

	if (humans == null)
	{
		Console.WriteLine("Массив пустой!!!");
	}
	else if (humans.Length == 0)
	{
		Console.WriteLine("Массив пустой!!!");
	}
	else
	{
		for (int i = 0; i < humans.Length; i++)
		{
			HatTabls(humans[i]);
		}
	}
	Console.WriteLine("--------------------------");
}
#endregion


#region Menu Меню
void SistemMenu()
{
	Console.WriteLine("1. Заполнение таблицы");

	Console.WriteLine("0. Выход");
}

#endregion

#endregion


Human[] humans = null;

bool humanList = true;

while (humanList)
{
	Console.Clear();
	PrintHatTabls(humans);

	SistemMenu();
	int menu = InputInt("Выберите меню!");

	switch (menu)
	{
		case 1:
			{
				Human human = FillingTabls(humans, ref id, true);
				AddArray(ref humans, human);
			}
			break;
		case 0:
			{
				Console.WriteLine("Конец работы!");
				humanList = false;
			}
			break;
		default:
			{
				Console.WriteLine("Неизвестная команда!");
			}
			break;
	}
	Console.ReadLine();
}