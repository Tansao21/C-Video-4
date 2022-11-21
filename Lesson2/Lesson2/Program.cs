using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* вводится символ 
             нужно определить
                   буква ли это
                   если это буква, то определить маленькая или большая
               цифра ли это
                   если цифра то четная или нечетная
               если не то и не другое, то вывести - неизвестный символ*/

            /*            char symbol;

                        Console.Write("Введите символ: ");
                        symbol = char.Parse(Console.ReadLine());

                        if (symbol >= 'а' && symbol <= 'я' ||
                           symbol >= 'А' && symbol <= 'Я')
                        {
                            Console.WriteLine("Это буква!");
                            if (symbol >= 'а' && symbol <= 'я')
                            {
                                Console.WriteLine("Маленькая!");
                            } 
                            else 
                            {
                                Console.WriteLine("Большая!");
                            }
                        }
                        else if (symbol >= '0' && symbol <= '9')
                        {
                            Console.WriteLine("Это цифра!");
                            if (symbol % 2 == 0)
                            {
                               Console.WriteLine("Четная!");
                            }
                            else
                            {
                                Console.WriteLine("Нечетная!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неизвестный символ!");
                        }



                        Console.ReadKey();*/






            /*  Даны зарплаты 3-х сотрудников: 
             *  найти наибольшую зарплату, 
             *  положить переменную max и вывести на экран*/


            int zp1;
            int zp2;
            int zp3;

            int max;

            Console.Write("Введите зарплату первого рабочего: ");
            zp1 = int.Parse(Console.ReadLine());

            Console.Write("Введите зарплату второго рабочего: ");
            zp2 = int.Parse(Console.ReadLine());

            Console.Write("Введите зарплату третьего рабочего: ");
            zp3 = int.Parse(Console.ReadLine());

            max = zp1;

            if (zp2 > max)
            {
                max = zp2;
                if (zp3 > max)
                {
                    max = zp3;
                }
            Console.WriteLine($"MAX zp = {max}");
            }
            Console.ReadKey();
        }



    }
}
