<<<<<<< HEAD
using System;

class Bai6
{
    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    public static void Run()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }
}
=======
using System;

class Bai6
{
    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    public static void Run()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
