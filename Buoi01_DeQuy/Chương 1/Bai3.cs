<<<<<<< HEAD
using System;
using System.Text;

class Bai3
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 3: ĐẢO NGƯỢC CHUỖI ---");

        Console.Write("Nhập vào một chuỗi bất kỳ: ");
        string chuoiGoc = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(chuoiGoc))
        {
            Console.WriteLine("Bạn chưa nhập chuỗi kìa!");
            return;
        }

        char[] kyTu = chuoiGoc.ToCharArray();
        Array.Reverse(kyTu);
        string chuoiDaoNguoc = new string(kyTu);

        Console.WriteLine($"Chuỗi sau khi đảo ngược: {chuoiDaoNguoc}");

    }
=======
using System;
using System.Text;

class Bai3
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 3: ĐẢO NGƯỢC CHUỖI ---");

        Console.Write("Nhập vào một chuỗi bất kỳ: ");
        string chuoiGoc = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(chuoiGoc))
        {
            Console.WriteLine("Bạn chưa nhập chuỗi kìa!");
            return;
        }

        char[] kyTu = chuoiGoc.ToCharArray();
        Array.Reverse(kyTu);
        string chuoiDaoNguoc = new string(kyTu);

        Console.WriteLine($"Chuỗi sau khi đảo ngược: {chuoiDaoNguoc}");

    }
>>>>>>> a829b11bf253bf7c8dee5d46e802712b4602654f
}