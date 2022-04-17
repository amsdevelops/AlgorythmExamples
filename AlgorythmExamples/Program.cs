using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        IIntegerSorter sorter = new MergeSorter();
        Stopwatch sw = Stopwatch.StartNew();
        sorter.Sort(CreateArray(100), sw);
        sorter.Sort(CreateArray(1_000), sw);
        sorter.Sort(CreateArray(10_000), sw);
        sorter.Sort(CreateArray(100_000), sw);
        sorter.Sort(CreateArray(1_000_000), sw);
        Console.ReadKey();
    }

    static int[] CreateArray(int capacity)
    {
        Random random = new Random();
        int[] array = new int[capacity];
        for (int i = 0; i < capacity; i++)
        {
            array[i] = random.Next(capacity);
        }
        return array;
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
