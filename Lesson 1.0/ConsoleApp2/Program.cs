using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

/*            int number;
            int a, b, c;
            int sum;
            Console.Write("Введите 3-х значное число: ");
            number = int.Parse(Console.ReadLine());
            a = number / 100;
            b = (number % 100) / 10;
            c = number % 10;
            sum = a + b + c;
            Console.WriteLine($"sum = {sum}");*/

            int number;
            int a, b, c, d, e, r;
            int sum1;
            int sum2;
            Console.Write("Введите 6-х значное число: ");
            number = int.Parse(Console.ReadLine());
            a = number / 100000;
            b = (number % 100000) / 10000;
            c = (number % 10000) / 1000;
            d = (number % 1000) / 100;
            e = (number % 100) / 10;
            r = number % 10;
            sum1 = a + b + c;
            sum2 = e + d + r;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            if (sum1 == sum2)
            {
                Console.WriteLine("Молодец!");
            } else
            {
                Console.WriteLine("ХУЙЛО!");
            }
           // Console.WriteLine($"sum = {sum}");

            Console.ReadKey();
        }
    }
}
