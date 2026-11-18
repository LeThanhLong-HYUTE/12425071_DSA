<<<<<<< HEAD
using System;

class Bai1
{
    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS1(n)}");
    }
}
=======
using System;

class Bai1
{
    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS1(n)}");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
