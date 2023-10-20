using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел в ряду: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выводится ряд Фибоначи: ");
            int a = 0;
            int b = 1;
            Console.WriteLine(a + " ");
            Console.WriteLine(b + " ");
            int i = 2;
            while (i <= n)
            {
                int sum = a + b;
                Console.WriteLine(" " + sum);
                a = b;
                b = sum;
                i++;
            }
        }
    }
}
