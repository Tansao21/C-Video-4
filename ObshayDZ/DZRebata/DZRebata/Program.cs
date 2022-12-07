int numNatur; // 50
int numMax = 0;
int numMin = 11;
int count = 0;
int ch1 = 0;

Console.Write("Input num: ");
numNatur = int.Parse(Console.ReadLine());
while (numNatur > 0)
{
	ch1 = numNatur % 10;
	if (ch1 > numMax)
	{
		numMax = ch1;
	}
	if (ch1 < numMin)
	{
		numMin = ch1;
	}
	count ++;
	numNatur = numNatur / 10;
}
if ((numMin - numMax) % 2 == 0)
{
	Console.WriteLine("Yes");
}
else
{
	Console.WriteLine("NO");
}