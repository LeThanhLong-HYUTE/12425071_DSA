<<<<<<< HEAD
using System;

class Bai6
{
    static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    public static void Run()
    {
        double[] arr = { 3.5, 1.2, 9.8, 5.4, 2.1 };
        BubbleSort(arr);
        Console.WriteLine("Day sau khi sap xep:");
        foreach (var x in arr) Console.Write(x + "  ");
        Console.WriteLine();
    }
}
=======
using System;

class Bai6
{
    static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    public static void Run()
    {
        double[] arr = { 3.5, 1.2, 9.8, 5.4, 2.1 };
        BubbleSort(arr);
        Console.WriteLine("Day sau khi sap xep:");
        foreach (var x in arr) Console.Write(x + "  ");
        Console.WriteLine();
    }
}
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
