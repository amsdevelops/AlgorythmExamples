using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        FactorArray<int> array = new FactorArray<int>(2);
        stopwatch.Start();
        PopulateArray(10, array, stopwatch);
        PopulateArray(100, array, stopwatch);
        PopulateArray(1_000, array, stopwatch);
        PopulateArray(10_000, array, stopwatch);
        PopulateArray(100_000, array, stopwatch);
        PopulateArray(1_000_000, array, stopwatch);
        PopulateArray(10_000_000, array, stopwatch);
        PopulateArray(100_000_000, array, stopwatch);
        Console.ReadKey();
    }

    static void PopulateArray(int num, IArray<int> array, Stopwatch stopwatch)
    {
        for (int i = 0; i < num; i++)
        {
            array.Add(i);
        }
        Console.WriteLine("{0} {1}", num, stopwatch.ElapsedMilliseconds);
    }
}
