<<<<<<< HEAD
using System;

class Bai4
{
    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double TinhS4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

    public static void Run()
    {
        Console.Write("Nhap co so x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{x}^{n} = {TinhS4(x, n)}");
    }
}
=======
using System;

class Bai4
{
    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double TinhS4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

    public static void Run()
    {
        Console.Write("Nhap co so x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{x}^{n} = {TinhS4(x, n)}");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
