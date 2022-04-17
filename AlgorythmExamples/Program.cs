using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
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
