<<<<<<< HEAD
using System;
using System.Diagnostics;

class Bai1
{
    static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
    {
        if (n == 1) return;
        ThapHaNoi(n - 1, nguon, dich, trungGian);
        ThapHaNoi(n - 1, trungGian, nguon, dich);
    }

    public static void Run()
    {
        Console.Write("Nhap so luong dia n: ");
        int n = int.Parse(Console.ReadLine());
        Stopwatch sw = Stopwatch.StartNew();
        ThapHaNoi(n, 'A', 'B', 'C');
        sw.Stop();
        Console.WriteLine($"Thoi gian thuc thi: {sw.Elapsed.TotalMilliseconds} ms");
    }
}
=======
using System;
using System.Diagnostics;

class Bai1
{
    static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
    {
        if (n == 1) return;
        ThapHaNoi(n - 1, nguon, dich, trungGian);
        ThapHaNoi(n - 1, trungGian, nguon, dich);
    }

    public static void Run()
    {
        Console.Write("Nhap so luong dia n: ");
        int n = int.Parse(Console.ReadLine());
        Stopwatch sw = Stopwatch.StartNew();
        ThapHaNoi(n, 'A', 'B', 'C');
        sw.Stop();
        Console.WriteLine($"Thoi gian thuc thi: {sw.Elapsed.TotalMilliseconds} ms");
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
