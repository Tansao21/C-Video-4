using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int day;
			Console.Write("Введите число: ");	
			day = int.Parse(Console.ReadLine());
			switch (day)
				{
				case 1:
					Console.WriteLine("ПН");
					break;
				case 2:
					Console.WriteLine("ВТ");
					break;
				case 3:
					Console.WriteLine("СР");
					break;
				case 4:
					Console.WriteLine("ЧТ");
					break;
				case 5:
					Console.WriteLine("ПТ");
					break;
				case 6:
					Console.WriteLine("СБ");
					break;
				case 7:
					Console.WriteLine("ВС");
					break;
			}
			Console.ReadKey();
		}
	}
}
