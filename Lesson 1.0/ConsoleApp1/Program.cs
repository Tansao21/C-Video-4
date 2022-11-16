using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // //текст
           // string x = "";
           // char c = ' ';
           //// число
           // int i;
           // byte b = 10;
           // double d = 8;
           // float f = 2;
           //// логический
           // bool b = true;

            int a = 3, b = 5;
            Console.WriteLine($"a = { a} b = { b}");

            /*a = b;
            b = a - 2;*/

            /*   int c = 2;
               a += c;
               b -= c;*/


            /*b = a;
            a = b + 2;*/

            /*int c = a;
            a = b;
            b = c;*/

            Console.WriteLine($"a = { a} b = { b}");

            Console.ReadKey();
        }
    }
}
