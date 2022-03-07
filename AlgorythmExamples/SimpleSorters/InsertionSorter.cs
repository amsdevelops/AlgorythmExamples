using System;
using System.Diagnostics;

class InsertionSort : AbstractSwapperSorter, IIntegerSorter
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        var N = array.Length;
        for (int i = 0; i < N; i++)
        {
            int j = i;
            while (j > 0 && array[j - 1] > array[j])
            {
                if (array[j - 1] > array[j])
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
            }
        }
        Console.WriteLine("{0} {1}", N, stopwatch.ElapsedMilliseconds);
        stopwatch.Stop();
    }
}

