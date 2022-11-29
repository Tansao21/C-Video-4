using System;

public class HelloWorld
{
	static public void Main()
	{
		int a = 2;
		int i = 1;
		int b = 10;
		int sum = 0;

		while (i < b)
		{
			a += a;
			i++;
		}
		sum = a;
		Console.WriteLine($"summa {sum}");
	}
}