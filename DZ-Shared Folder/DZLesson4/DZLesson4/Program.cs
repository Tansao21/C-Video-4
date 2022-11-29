// Начав тренеровки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдушего дня. определить:



// 1) За сколько дней его дневной пробег привысит 20 км
/*double kilStart = 10;
double kilEnd = 20;
double percent = 10;
int days = 0;
while (kilStart <= kilEnd)
{

	kilStart += kilStart * percent / 100.0;
	days++;


	Console.WriteLine($"dist = {kilStart} for {days} years");
}
Console.ReadKey();*/


// 2) Сколько суммарно он пробежит за 20 дней 
/*int days = 0;
double kilStar = 10;
int daysGenerals = 20;
double percent = 10;
double sum = kilStar;

while (days < daysGenerals)
{
	kilStar += kilStar * percent / 100.0;
	days++;
	sum += kilStar;
	Console.WriteLine($"За {days} - суммарно пробежит {sum}");
}

Console.ReadKey();*/


// 3) построить таблицу его пробега за 1,2,3....10 день пробега

int days = 0;
double kilStar = 10;
int daysGenerals = 10;
double percent = 10;
double sum = kilStar;

while (days < daysGenerals)
{
	kilStar += kilStar * percent / 100.0;
	days++;
	
	Console.WriteLine($"За {days} -  пробежит {kilStar}");
}

Console.ReadKey();