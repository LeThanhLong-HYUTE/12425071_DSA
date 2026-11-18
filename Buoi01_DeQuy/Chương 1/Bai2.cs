<<<<<<< HEAD
using System;
using System.Text;

class Bai2
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 2: BÀI TOÁN FIZZBUZZ ---");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();

    }
=======
using System;
using System.Text;

class Bai2
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 2: BÀI TOÁN FIZZBUZZ ---");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();

    }
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
}