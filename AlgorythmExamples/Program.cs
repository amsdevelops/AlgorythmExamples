using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
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
