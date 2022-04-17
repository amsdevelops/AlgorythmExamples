using System;
using System.Diagnostics;

class BubbleSorter : AbstractSwapperSorter, IIntegerSorter
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        var N = array.Length;
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N - i - 1; j++)
                if (array[j] > array[j + 1])
                    Swap(ref array[j], ref array[j + 1]);
        Console.WriteLine("{0} {1}", N, stopwatch.ElapsedMilliseconds);
        stopwatch.Stop();
    }
}

