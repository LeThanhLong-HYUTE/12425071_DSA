<<<<<<< HEAD
using System;

class Bai3
{
    static bool IsPrime(long n)
    {
        if (n < 2) return false;
        for (long i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static void Run()
    {
        Console.Write("Nhap so nguyen can kiem tra: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? $"{n} la so nguyen to." : $"{n} khong phai so nguyen to.");
    }
}
=======
using System;

class Bai3
{
    static bool IsPrime(long n)
    {
        if (n < 2) return false;
        for (long i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static void Run()
    {
        Console.Write("Nhap so nguyen can kiem tra: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? $"{n} la so nguyen to." : $"{n} khong phai so nguyen to.");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
