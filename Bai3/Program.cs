using System;
using System.Diagnostics;
namespace Cautrucdulieu
{
    internal class Program
    {
            static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bai 2
            Bai3();
        }
        static void Bai3()
{
    int[][] tests =
    {
        new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
        new[] { -8, -3, -6, -2, -5, -4 },
        new[] { 1, 2, 3 }
    };
    foreach (var t in tests)
    {
        int a = PhienBanA(t), b = PhienBanB(t);
        Console.WriteLine($"A = {a}, B = {b}, giong nhau: {a == b}");
    }

    int[] sizes = { 100, 1000, 10000 };
    int soLan = 5;
    Random rnd = new Random(123);

    Console.WriteLine("\nn\tA (ms)\tKadane (ms)");
    foreach (int n in sizes)
    {
        int[] data = new int[n];
        for (int i = 0; i < n; i++) data[i] = rnd.Next(-100, 101);

        double tongA = 0, tongB = 0;
        for (int k = 0; k < soLan; k++)
        {
            var sw = Stopwatch.StartNew();
            int ra = PhienBanA(data);
            sw.Stop();
            tongA += sw.Elapsed.TotalMilliseconds;

            sw.Restart();
            int rb = PhienBanB(data);
            sw.Stop();
            tongB += sw.Elapsed.TotalMilliseconds;

            if (ra != rb) Console.WriteLine("KHAC KET QUA!");
        }
        Console.WriteLine($"{n}\t{tongA / soLan:F4}\t{tongB / soLan:F4}");
    }
}
        }
    }

