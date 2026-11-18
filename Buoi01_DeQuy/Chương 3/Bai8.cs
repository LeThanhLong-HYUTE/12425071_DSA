<<<<<<< HEAD
using System;

class Bai8
{
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double TinhS8(int n)
    {
        return Can(1, n);
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS8(n):F4}");
    }
}
=======
using System;

class Bai8
{
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double TinhS8(int n)
    {
        return Can(1, n);
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS8(n):F4}");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
