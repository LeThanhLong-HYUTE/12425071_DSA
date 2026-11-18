<<<<<<< HEAD
using System;

class Bai5
{
    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    public static void Run()
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Uoc so le lon nhat cua {n} la: {UocLeMax(n)}");
    }
}
=======
using System;

class Bai5
{
    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    public static void Run()
    {
        Console.Write("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Uoc so le lon nhat cua {n} la: {UocLeMax(n)}");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
