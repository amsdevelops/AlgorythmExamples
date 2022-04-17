using System;
using System.Diagnostics;

class ShellSort : AbstractSwapperSorter, IIntegerSorter
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        var N = array.Length / 2;
        while (N >= 1)
        {
            for (var i = N; i < array.Length; i++)
            {
                int j = i;
                while (j >= N && (array[j - N] > array[j]))
                {
                    Swap(ref array[j], ref array[j - N]);
                    j -= N;
                }
            }
            N /= 2;
        }
        Console.WriteLine("{0} {1}", array.Length, stopwatch.ElapsedMilliseconds);
        stopwatch.Stop();
    }
}

