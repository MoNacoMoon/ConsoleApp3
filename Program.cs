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
            //Console.WriteLine("Числа Армстронга из трех цифр:");

            //for (int i = 100; i < 1000; i++)
            //{
            //    int num = i;
            //    int count = 0;
            //    int sum = 0;
            //    while (num > 0)
            //    {
            //        count++;
            //        num /= 10;
            //    }
            //    num = i;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        sum += (int)Math.Pow(digit, count);
            //        num /= 10;
            //    }
            //    if (i == sum)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //for (int i = 1000; i < 10000; i++)
            //{
            //    int num = i;
            //    int firstSum = (num / 1000) + ((num / 100) % 10);
            //    int secondSum = (num % 100) + (num % 10);
            //    int midSum = ((num / 100) % 10) + (num % 10);

            //    if (firstSum == secondSum && midSum * 10 == 100)
            //    {
            //        Console.WriteLine(i);
            //    }




            //}


            //int count = 0;

            //for (int i = 100000; i < 1000000; i++)
            //{
            //    int num = i;
            //    int firstHalf = num / 1000;
            //    int secondHalf = num % 1000;

            //    if ((firstHalf / 100 + firstHalf % 100 / 10 + firstHalf % 10) ==
            //        (secondHalf / 100 + secondHalf % 100 / 10 + secondHalf % 10))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Количество счастливых билетов: {0}", count);





            //Console.WriteLine("Совершенные числа до 100 000:");

            //for (int i = 2; i < 100000; i++)
            //{
            //    int sum = 1;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sum += j + i / j;
            //        }
            //    }

            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }






            //int n = int.Parse(Console.ReadLine());
            //int count = 0, t = 64;
            //while (n >= 0)
            //{
            //    while (n - t >= 0)
            //    {
            //        count++;
            //        n -= t;
            //    }
            //    Console.WriteLine($"{t} = {count}");
            //    count = 0;
            //    t /= 2;
            //}




            //рисунок;
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //while(a <= b) 
            //{
            //    for(int i = 0; i < a; i++)
            //    {
            //        Console.Write(a + " ");
            //    }
            //    Console.WriteLine();
            //    a++;
            //}



            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = a;
            //count = a - 1;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count -= 2;
            //    half--;
            //    Console.WriteLine();
            //}



            //int a = int.Parse(Console.ReadLine());
            //int half = a;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    half--;
            //    Console.WriteLine();
            //}



            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = a;
            //count = a - 1;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count -= 2;
            //    half--;
            //    Console.WriteLine();
            //}
            //for (int j = a; j >= 0; j--)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count += 2;
            //    half++;
            //    Console.WriteLine();
            //}


            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = 0;
            //count = a;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    half++;
            //    count -= 1;
            //    Console.WriteLine();
            //}



            //Console.ReadKey();
        }
    }
}
        
    

        
    

