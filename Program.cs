using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.Write("20 ");
            //}


            //2
            //double a = 20.4;
            //for (int i = 2; i <= 20; i++)
            //{
            //    double b = i * a;
            //    Console.WriteLine($"{b:F2}") ;
            //}

            //3
            //int a = 0;
            //for (int b = 10; b < 99; b++)
            //{
            //    if (b % 2 == 0)
            //    {
            //        Console.Write(b + " ");
            //        a++;
            //    }
            //}

            //4
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int c = rnd.Next(-40, 40);
            //    Console.Write(c + " ");
            //}

            //5

            //6

            //7
            //Random rnd = new Random();
            //for (int i = 0; i < 8; i++)
            //{
            //    int num = rnd.Next(-30, 31); 
            //    string sign = num > 0 ? "положительное" : (num < 0 ? "отрицательное" : "ноль");
            //    string parity = num % 2 == 0 ? "четное" : "нечетное";
            //    Console.WriteLine($"{num}: {sign}, {parity}");

            //}

            //8
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            for(int i = 0; i <=n; i++)
            {
                c+=i;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}